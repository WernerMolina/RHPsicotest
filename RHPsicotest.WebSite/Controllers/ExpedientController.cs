using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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
            List<ExpedientDTO> expedients = await expedientRepository.GetAllExpedients();

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
                        string position = ((ClaimsIdentity)User.Identity).FindFirst("Position").Value;

                        // Id, Correo, Puesto
                        (string, string, string) currentCandidate = (candidateId, email, position);

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
        [Route("/Expediente/Editar")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            ExpedientUpdateVM expedient = await expedientRepository.GetExpedientUpdateVM(id);

            return View(expedient);
        }

        [HttpPost]
        [Route("/Expediente/Editar")]
        public async Task<IActionResult> Edit(ExpedientUpdateVM expedientUpdateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await expedientRepository.UpdateExpedient(expedientUpdateVM);

                    if (result)
                    {
                        return RedirectToAction("Index", "Expedient");
                    }
                }

                return View(expedientUpdateVM);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }




        [HttpGet]
        [Route("/CurriculumVitae")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> ShowCurriculum(int id)
        {
            byte[] fileBytes = await expedientRepository.GetPDFInBytes(id);

            ViewData["PDF"] = fileBytes;

            return File(fileBytes, "application/pdf");
        }

        [HttpGet]
        [Route("/Resultados")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> ShowResultsPDF(int id)
        {
            try
            {
                string url = $"http://localhost:8080/jasperserver/rest_v2/reports/reports/interactive/RHpsicotest.pdf?j_username=jasperadmin&j_password=jasperadmin&inline=true$&Identificador={id}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                        return File(fileBytes, "application/pdf");
                    }

                    return StatusCode(StatusCodes.Status500InternalServerError, response.RequestMessage);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
