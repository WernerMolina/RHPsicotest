using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.ViewModels.Candidate;
using System;
using System.Collections.Generic;
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
            IEnumerable<CandidateDTO> candidates = await candidateRepository.GetAllCandidates();

            return View(candidates);
        }
        
        [HttpGet]
        [Route("/Tests")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public async Task<IActionResult> GetTestNames(int positionId)
        {
            List<string> tests = await candidateRepository.GetTestNames(positionId);

            return Json(tests);
        }

        [HttpGet]
        [Route("/Candidato/Crear")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Role = await candidateRepository.GetRoleName();
            ViewBag.Positions = await candidateRepository.GetAllPositions();

            return View();
        }

        [HttpPost]
        [Route("/Candidato/Crear")]
        public async Task<IActionResult> Create(CandidateVM candidateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CandidateSendVM candidateSendVM = await candidateRepository.AddCandidate(candidateVM);

                    if (candidateSendVM != null)
                    {
                        return RedirectToAction("SendMail", "Candidate", candidateSendVM);
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

        [HttpGet]
        [Route("/EnviarCorreo")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public IActionResult SendMail(CandidateSendVM candidate, string nothing = null)
        {
            return View(candidate);
        }

        [HttpPost]
        [Route("/EnviarCorreo")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public IActionResult SendMail(CandidateSendVM candidate)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SendEmail.Send(candidate.Email, candidate.Password);

                    return RedirectToAction("Index", "Candidate");
                }

                return View(candidate);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
