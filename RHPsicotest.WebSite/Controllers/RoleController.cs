using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleRepository roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        [Route("/Roles")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Role> roles = await roleRepository.GetAllRoles();

            return View(roles);
        }
        
        [Route("/Role/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            Role role = await roleRepository.GetRole(id);

            return View(role);
        }

        [HttpGet]
        [Route("/Rol/Crear")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Permissions = await roleRepository.GetAllPermissions();

            return View();
        }

        [HttpPost]
        [Route("/Rol/Crear")]
        public async Task<IActionResult> Create(Role role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await roleRepository.AddRole(role);

                    if(result != null)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                }

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(role);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Rol/Editar/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            Role role = await roleRepository.GetRole(id);
            ViewBag.Permissions = await roleRepository.GetAllPermissions();

            return View(role);
        }

        [HttpPost]
        [Route("/Rol/Editar/{id:int}")]
        public async Task<IActionResult> Edit(Role role, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await roleRepository.UpdateRole(role);

                    if(result)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                }

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(role);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [HttpGet]
        [Route("/Rol/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            Role role = await roleRepository.GetRole(id);

            return View(role);
        }

        [HttpPost]
        [Route("/Rol/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                var result = await roleRepository.DeleteRole(id);

                if(result)
                {
                    return RedirectToAction("Index", "Role");
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
