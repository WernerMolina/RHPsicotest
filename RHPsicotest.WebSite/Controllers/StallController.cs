using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RHPsicotest.WebSite.Controllers
{
    public class StallController : Controller
    {
        private readonly IStallRepository stallRepository;

        public StallController(IStallRepository stallRepository)
        {
            this.stallRepository = stallRepository;
        }

        [Route("/Stalls")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Stall> stalls = await stallRepository.GetAllStalls();

            return View(stalls);
        }

        [Route("/Stall/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            Stall stall = await stallRepository.GetStall(id);

            return View(stall);
        }

        [HttpGet]
        [Route("/Puesto/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/Puesto/Crear")]
        public async Task<IActionResult> Create(Stall stall)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await stallRepository.AddStall(stall);

                    if (result != null)
                    {
                        return RedirectToAction("Index", "Stall");
                    }
                }

                return View(stall);
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
            Stall stall = await stallRepository.GetStall(id);

            return View(stall);
        }

        [HttpPost]
        [Route("/Puesto/Editar/{id:int}")]
        public async Task<IActionResult> Edit(Stall stall, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await stallRepository.UpdateStall(stall);

                    if (result)
                    {
                        return RedirectToAction("Index", "Stall");
                    }
                }

                return View(stall);
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
            Stall stall = await stallRepository.GetStall(id);

            return View(stall);
        }

        [HttpPost]
        [Route("/Puesto/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                var result = await stallRepository.DeleteStall(id);

                if (result)
                {
                    return RedirectToAction("Index", "Stall");
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
