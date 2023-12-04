using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionRepository positionRepository;

        public PositionController(IPositionRepository positionRepository)
        {
            this.positionRepository = positionRepository;
        }

        [HttpGet]
        [Route("/Puestos")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "List-Position-Policy")]
        public async Task<IActionResult> Index()
        {
            List<PositionDTO> positions = await positionRepository.GetAllPositions();

            return View(positions);
        }

        [HttpGet]
        [Route("/Puesto/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Position-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Tests = await positionRepository.GetAllTests();

            return View();
        }

        [HttpPost]
        [Route("/Puesto/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-Position-Policy")]
        public async Task<IActionResult> Create(PositionVM positionVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await positionRepository.AddPosition(positionVM);

                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = "No se pudo guardar el puesto, intentelo después";
                    }
                }

                ViewBag.Tests = await positionRepository.GetAllTests();

                return View(positionVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.Tests = await positionRepository.GetAllTests();

                return View(positionVM);
            }
        }

        [HttpGet]
        [Route("/Puesto/Editar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Edit-Position-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            PositionUpdateVM position = await positionRepository.GetPositionUpdate(id);

            if (position == null) return RedirectToAction(nameof(Index));

            ViewBag.Tests = await positionRepository.GetAllTests();

            return View(position);
        }

        [HttpPost]
        [Route("/Puesto/Editar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Edit-Position-Policy")]
        public async Task<IActionResult> Edit(PositionUpdateVM positionUpdateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await positionRepository.UpdatePosition(positionUpdateVM);

                    if (result)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Message = "No se pudo guardar el puesto, intentelo después";
                    }
                }

                ViewBag.Tests = await positionRepository.GetAllTests();

                return View(positionUpdateVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.Tests = await positionRepository.GetAllTests();

                return View(positionUpdateVM);
            }
        }

        [HttpPost]
        [Route("/Puesto/Eliminar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Delete-Position-Policy")]
        public async Task<IActionResult> Delete(int positionId)
        {
            try
            {
                bool result = await positionRepository.DeletePosition(positionId);

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
