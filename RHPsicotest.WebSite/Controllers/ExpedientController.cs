using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
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
        public IActionResult ConfirmPolicies(bool acept)
        {
            if (acept)
                return RedirectToAction("Expedientes");

            return View();
        }

        [HttpGet]
        [Route("/Expediente")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public IActionResult CandidateCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/Expediente")]
        public async Task<IActionResult> CandidateCreate(ExpedientVM expedientVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isFileTypePDF = Helper.IsFileTypePDF(expedientVM.CurriculumVitae);

                    if (isFileTypePDF)
                    {
                        bool result = await expedientRepository.AddExpedient(expedientVM);

                        if (result)
                        {
                            return RedirectToAction("Index", "Home");
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
