using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class ExpedientController : Controller
    {

        List<string> academicFormations = new List<string>
        {
            "Bachiller",
            "Directivo",
            "Ingeniero",
            "Licenciado",
            "Profesional en Publicidad",
            "Técnico Industrial",
            "Técnico Comercial",
            "Jefe de Vigilancia",
            "Agente Comercial",
            "Jefe Administrativo",
            "Administrativo",
            "Analista Programador",
            "Técnico en Método",
            "Jefatura",
            "Operario Mecánico",
            "Secretaria",
            "Asistente Administrativa",
            "Vendedor",
            "Vigilante",
            "Operario no Cualificado",
            "Profesinal de Oficio",
            "Subalternos",
            "Supervisora de Ventas"
        };

        private readonly IExpedientRepository expedientRepository;

        public ExpedientController(IExpedientRepository expedientRepository)
        {
            this.expedientRepository = expedientRepository;
        }

        [HttpGet]
        [Route("/Expedientes")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "List-Expedient-Policy")]
        public async Task<IActionResult> Index()
        {
            List<ExpedientDTO> expedients = await expedientRepository.GetAllExpedients();

            return View(expedients);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("/ConfirmarPoliticas")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "ConfirmPolicies-Expedient-Policy")]
        public IActionResult ConfirmPolicies()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("/ConfirmarPoliticas")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "ConfirmPolicies-Expedient-Policy")]
        public IActionResult ConfirmPolicies(bool accept)
        {
            if (accept)
                return RedirectToAction(nameof(Create));

            return View();
        }

        [HttpGet]
        [Route("/Expediente/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Expedient-Policy")]
        public async Task<IActionResult> Create()
        {
            int candidateId = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            bool hasExpedient = await expedientRepository.HasExpedient(candidateId);

            if (hasExpedient) return RedirectToAction("AssignedTests", "Test");

            ViewBag.AcademicFormations = academicFormations;

            return View();
        }

        [HttpPost]
        [Route("/Expediente/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Expedient-Policy")]
        public async Task<IActionResult> Create(ExpedientVM expedientVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await expedientRepository.AddExpedient(expedientVM);

                    if (result)
                    {
                        return RedirectToAction("AssignedTests", "Test");
                    }
                    else
                    {
                        ViewBag.Message = "No se pudo guardar su información, por favor, intentelo otra vez";
                    }
                }

                ViewBag.AcademicFormations = academicFormations;

                return View(expedientVM);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;

                ViewBag.AcademicFormations = academicFormations;

                return View(expedientVM);
            }
        }

        [HttpGet]
        [Route("/Expediente/Editar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Edit-Expedient-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            ExpedientUpdateVM expedient = await expedientRepository.GetExpedientUpdateVM(id);

            if (expedient == null) return RedirectToAction(nameof(Index));

            ViewBag.AcademicFormations = academicFormations;

            return View(expedient);
        }

        [HttpPost]
        [Route("/Expediente/Editar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Edit-Expedient-Policy")]
        public async Task<IActionResult> Edit(ExpedientUpdateVM expedientUpdateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (expedientUpdateVM.Age < 15)
                    {
                        ViewBag.Message = "La edad establecida no esta permitida";
                    }
                    else
                    {
                        bool result = await expedientRepository.UpdateExpedient(expedientUpdateVM);

                        if (result)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo actualizar el expediente, por favor, intentelo otra vez";
                        }
                    }
                }

                ViewBag.AcademicFormations = academicFormations;

                return View(expedientUpdateVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.AcademicFormations = academicFormations;

                return View(expedientUpdateVM);
            }
        }

        [HttpGet]
        [Route("/Curriculum-Vitae")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "WatchCurriculums-Expedient-Policy")]
        public async Task<IActionResult> ShowCurriculum(int id)
        {
            byte[] fileBytes = await expedientRepository.GetPDFInBytes(id);

            ViewData["PDF"] = fileBytes;

            return View();
        }

        [HttpGet]
        [Route("/Reporte")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
        //Policy = "WatchReports-Expedient-Policy")]
        public async Task<IActionResult> ReportPDF(int id)
        {
            List<ResultDTO> results = await expedientRepository.GetResults(id);

            ViewBag.Expedient = await expedientRepository.GetExpedient(id);

            return View(results);
        }
    }
}
