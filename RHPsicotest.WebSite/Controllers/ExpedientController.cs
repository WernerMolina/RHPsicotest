using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class ExpedientController : Controller
    {
        private readonly IExpedientRepository expedientRepository;

        public ExpedientController(IExpedientRepository expedientRepository)
        {
            this.expedientRepository = expedientRepository;
        }

        [HttpGet]
        [Route("/Expedientes")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Expedient> expedients = await expedientRepository.GetAllExpedients();

            return View(expedients);
        }
        
        [HttpGet]
        [Route("/ConfirmarPoliticas")]
        public IActionResult ConfirmPolicies()
        {
            return View();
        }

        [HttpPost]
        [Route("/ConfirmarPoliticas")]
        public IActionResult ConfirmPolicies(bool accept)
        {
            if (accept)
                return View("Create");

            return View();
        }

        [HttpGet]
        [Route("/Expediente")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/Expediente")]
        public async Task<IActionResult> Create(ExpedientVM expedientVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isFileTypePDF = Helper.IsFileTypePDF(expedientVM.CurriculumVitae);

                    if (isFileTypePDF)
                    {
                        string candidateId = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value;
                        string email = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value;
                        string stall = ((ClaimsIdentity)User.Identity).FindFirst("Position").Value;

                        (string, string, string) currentCandidate = (candidateId, email, stall);

                        bool result = await expedientRepository.AddExpedient(expedientVM, currentCandidate);

                        if (result)
                        {
                            return RedirectToAction("Test1", "Test");
                        }
                    }
                }

                return View(expedientVM);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }




        [HttpGet]
        [Route("/CurriculumVitae")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> ShowFilePDF(int id)
        {
            byte[] fileBytes = await expedientRepository.GetPDFInBytes(id);

            ViewData["PDF"] = fileBytes;

            //return File(fileBytes, "application/pdf");

            return File(fileBytes, "application/pdf");
        }
       
    }
}
