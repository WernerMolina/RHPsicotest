using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.ViewModels.User;

namespace RHPsicotest.WebSite.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionRepository positionRepository;

        public PositionController(IPositionRepository positionRepository)
        {
            this.positionRepository = positionRepository;
        }

        [Route("/Puestos")]
        public async Task<IActionResult> Index()
        {
            List<PositionDTO> positions = await positionRepository.GetAllPositions();

            return View(positions);
        }

        [HttpGet]
        [Route("/Puesto/Crear")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Tests = await positionRepository.GetAllTests();

            return View();
        }

        [HttpPost]
        [Route("/Puesto/Crear")]
        public async Task<IActionResult> Create(PositionVM positionVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    positionVM.PositionName = positionVM.PositionName.Trim();
                    positionVM.PositionHigher = positionVM.PositionHigher.Trim();
                    positionVM.Department = positionVM.Department.Trim();

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
        public async Task<IActionResult> Edit(int id)
        {
            PositionUpdateVM position = await positionRepository.GetPositionUpdate(id);

            if (position == null) return RedirectToAction(nameof(Index));

            ViewBag.Tests = await positionRepository.GetAllTests();

            return View(position);
        }

        [HttpPost]
        [Route("/Puesto/Editar")]
        public async Task<IActionResult> Edit(PositionUpdateVM positionUpdateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    positionUpdateVM.PositionName = positionUpdateVM.PositionName.Trim();
                    positionUpdateVM.PositionHigher = positionUpdateVM.PositionHigher.Trim();
                    positionUpdateVM.Department = positionUpdateVM.Department.Trim();

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
