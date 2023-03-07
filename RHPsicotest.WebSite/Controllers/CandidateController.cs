using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
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
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Candidate> candidates = await candidateRepository.GetAllCandidates();

            return View(candidates);
        }
        
        [HttpGet]
        [Route("/EnviarCorreo")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public IActionResult SendMail(CandidateSendDTO user, string nothing = null)
        {
            return View(user);
        }
        
        [HttpPost]
        [Route("/EnviarCorreo")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public IActionResult SendMail(CandidateSendDTO user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SendEmail.Send(user.Email, user.Password);

                    return RedirectToAction("Index", "Candidate");
                }

                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Contraseña/Crear")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Role = await candidateRepository.GetRoleName();
            ViewBag.Positions = await candidateRepository.GetAllPositions();

            return View();
        }

        [HttpPost]
        [Route("/Contraseña/Crear")]
        public async Task<IActionResult> Create(CandidateVM candidateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CandidateSendDTO candidateSendDTO = await candidateRepository.AddCandidate(candidateVM);

                    if (candidateSendDTO != null)
                    {
                        return RedirectToAction("SendMail", "Candidate", candidateSendDTO);
                    }
                }

                ViewBag.Role = await candidateRepository.GetRoleName();
                ViewBag.Positions = await candidateRepository.GetAllPositions();

                return View(candidateVM);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
