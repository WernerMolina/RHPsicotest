using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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
            IEnumerable<Position> positions = await positionRepository.GetAllPositions();

            return View(positions);
        }

        [Route("/Puesto/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            Position position = await positionRepository.GetPosition(id);

            return View(position);
        }

        [HttpGet]
        [Route("/Puesto/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/Puesto/Crear")]
        public async Task<IActionResult> Create(Position _position)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Position position = await positionRepository.AddPosition(_position);

                    if (position != null)
                    {
                        return RedirectToAction("Index", "Position");
                    }
                }

                return View(_position);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Puesto/Editar/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            Position position = await positionRepository.GetPosition(id);

            return View(position);
        }

        [HttpPost]
        [Route("/Puesto/Editar/{id:int}")]
        public async Task<IActionResult> Edit(Position position, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await positionRepository.UpdatePosition(position);

                    if (result)
                    {
                        return RedirectToAction("Index", "Position");
                    }
                }

                return View(position);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Puesto/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            Position position = await positionRepository.GetPosition(id);

            return View(position);
        }

        [HttpPost]
        [Route("/Puesto/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                bool result = await positionRepository.DeletePosition(id);

                if (result)
                {
                    return RedirectToAction("Index", "Position");
                }

                return View();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
