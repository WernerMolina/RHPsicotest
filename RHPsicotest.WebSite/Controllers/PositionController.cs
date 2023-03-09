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
        public async Task<IActionResult> Create(PositionVM positionVM, List<int> testsId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await positionRepository.AddPosition(positionVM, testsId);

                    if (result)
                    {
                        return RedirectToAction("Index", "Position");
                    }
                }

                ViewBag.Tests = await positionRepository.GetAllTests();

                return View(positionVM);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Puesto/Editar")]
        public async Task<IActionResult> Edit(int id)
        {
            (PositionUpdateVM, MultiSelectList) position = await positionRepository.GetPositionAndTestsSelected(id);

            ViewBag.Tests = position.Item2;

            return View(position.Item1);
        }

        [HttpPost]
        [Route("/Puesto/Editar")]
        public async Task<IActionResult> Edit(PositionUpdateVM position, List<int> testsId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await positionRepository.UpdatePosition(position, testsId);

                    if (result)
                    {
                        return RedirectToAction("Index", "Position");
                    }
                }

                ViewBag.Tests = await positionRepository.GetTestsSelected(testsId);

                return View(position);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("/Puesto/Eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool result = await positionRepository.DeletePosition(id);

                if (result)
                {
                    return RedirectToAction("Index", "Position");
                }

                return RedirectToAction("Index", "Position");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
