using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class ExpedientController : Controller
    {
        private readonly IExpedientRepository expedientRepository;

        List<string> academicFormations = new List<string>
        {
            "Bachiller",
            "Directivo",
            "Ingeniero",
            "Licenciado",
            "Profesional",
            "Técnico",
            "Técnico Comercial",
            "Técnico de Organización",
            "Inspector o Delegado",
            "Agente de Venta",
            "Jefe Administrativo",
            "Administrativo Oficial o Auxiliar",
            "Analista o Programador",
            "Monitor o Mandos Medios",
            "Operario Mecánico",
            "Secretaria",
            "Administrativa",
            "Vendedor",
            "Vigilante",
            "Operario no Cualificado",
            "Profesinal de Oficio",
            "Subalternos",
            "Supervisora de Ventas",
        };

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
        [AllowAnonymous]
        [Route("/ConfirmarPoliticas")]
        public IActionResult ConfirmPolicies()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("/ConfirmarPoliticas")]
        public IActionResult ConfirmPolicies(bool accept)
        {
            if (accept)
                return RedirectToAction(nameof(Create));

            return View();
        }

        [HttpGet]
        [Route("/Crear/Expediente")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public IActionResult Create()
        {
            ViewBag.AcademicFormations = academicFormations;

            return View();
        }

        [HttpPost]
        [Route("/Crear/Expediente")]
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
                            return RedirectToAction(nameof(TestController.AssignedTests));
                        }
                    }
                }

                ViewBag.AcademicFormations = academicFormations;

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

            ViewBag.AcademicFormations = academicFormations;

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

                ViewBag.AcademicFormations = academicFormations;

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
                string url = $"http://localhost:8080/jasperserver/rest_v2/reports/reports/TESTTER.pdf?j_username=jasperadmin&j_password=jasperadmin&inline=true&Identificador={id}";

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
