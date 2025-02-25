﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ICandidateRepository candidateRepository;

        public CandidateController(ICandidateRepository candidateRepository)
        {
            this.candidateRepository = candidateRepository;
        }

        [HttpGet]
        [Route("/Candidatos")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, 
            Policy = "List-Candidate-Policy")]
        public async Task<IActionResult> Index()
        {
            List<CandidateDTO> candidates = await candidateRepository.GetAllCandidates();

            return View(candidates);
        }
        
        [HttpGet]
        [Route("/Tests")]
        public async Task<IActionResult> GetTestNames(int positionId)
        {
            List<string> tests = await candidateRepository.GetTestNames(positionId);

            return Json(tests);
        }

        [HttpGet]
        [Route("/Candidato/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Candidate-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Role = await candidateRepository.GetRoleName();
            ViewBag.Positions = await candidateRepository.GetAllPositions();

            return View();
        }

        [HttpPost]
        [Route("/Candidato/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Candidate-Policy")]
        public async Task<IActionResult> Create(CandidateVM candidateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool candidateExists = await candidateRepository.CandidateExists(candidateVM.Email.Trim().ToUpper());

                    if (candidateExists)
                    {
                        ViewBag.Message = "El correo del candidato ya esta registrado";
                    }
                    else
                    {
                        CandidateSendVM candidateSendVM = await candidateRepository.AddCandidate(candidateVM);

                        if (candidateSendVM != null)
                        {
                            return RedirectToAction(nameof(SendMail), candidateSendVM);
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo guardar el candidato, intentelo otra vez";
                        }
                    }
                }

                ViewBag.Role = await candidateRepository.GetRoleName();
                ViewBag.Positions = await candidateRepository.GetAllPositions();

                return View(candidateVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;;
                ViewBag.Role = await candidateRepository.GetRoleName();
                ViewBag.Positions = await candidateRepository.GetAllPositions();

                return View(candidateVM);
            }
        }

        [HttpGet]
        [Route("/EnviarCorreo")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Candidate-Policy")]
        public IActionResult SendMail(CandidateSendVM candidate, string nothing = null)
        {
            return View(candidate);
        }

        [HttpPost]
        [Route("/EnviarCorreo")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Candidate-Policy")]
        public IActionResult SendMail(CandidateSendVM candidateSendVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SendEmail.Send(candidateSendVM.Email, candidateSendVM.Password);

                    return RedirectToAction(nameof(Index));
                }

                return View(candidateSendVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                return View(candidateSendVM);
            }
        }

        [HttpGet]
        [Route("/ReenviarCorreo")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, 
            Policy = "Resend-Candidate-Policy")]
        public async Task<IActionResult> ResendMail(int id, string nothing = null)
        {
            CandidateResendMailVM candidate = await candidateRepository.GetCandidateResendMailVM(id);

            return View(candidate);
        }

        [HttpPost]
        [Route("/ReenviarCorreo")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Resend-Candidate-Policy")]
        public async Task<IActionResult> ResendMail(CandidateResendMailVM candidateResendMailVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (candidateResendMailVM.TestsId != null)
                    {
                        bool result = await candidateRepository.DeleteResultsToCandidate(candidateResendMailVM);

                        if (result)
                        {
                            SendEmail.Send(candidateResendMailVM.Email, candidateResendMailVM.Password);

                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo realizar el reenvio, intentelo otra vez";
                        }
                    }
                    else
                    {
                        SendEmail.Send(candidateResendMailVM.Email, candidateResendMailVM.Password);

                        return RedirectToAction(nameof(Index));
                    }
                }

                return View(candidateResendMailVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                return View(candidateResendMailVM);
            }
        }

        [HttpPost]
        [Route("/Candidato/Eliminar")]
        public async Task<IActionResult> Delete(int candidateId)
        {
            try
            {
                bool result = await candidateRepository.DeleteCandidate(candidateId);

                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
