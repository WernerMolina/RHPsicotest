using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
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
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Roles-Policy")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Role> roles = await roleRepository.GetAllRoles();

            return View(roles);
        }
        
        [Route("/Role/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            Role role = await roleRepository.GetRoleWithPermissions(id);

            return View(role);
        }

        [HttpGet]
        [Route("/Rol/Crear")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-Role-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Permissions = await roleRepository.GetAllPermissions();

            return View();
        }

        [HttpPost]
        [Route("/Rol/Crear")]
        public async Task<IActionResult> Create(Role _role, List<int> permissions)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Role role = await roleRepository.AddRole(_role, permissions);

                    if(role != null)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                }

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(_role);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Rol/Editar/{id:int}")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Edit-Role-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            Role role = await roleRepository.GetRoleWithPermissions(id);
            ViewBag.Permissions = await roleRepository.GetPermissionsSelected(id);

            return View(role);
        }

        [HttpPost]
        [Route("/Rol/Editar/{id:int}")]
        public async Task<IActionResult> Edit(Role role, List<int> permissions)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await roleRepository.UpdateRole(role, permissions);

                    if(result)
                    {
                        return RedirectToAction("Index", "Role");
                    }
                }

                ViewBag.Permissions = await roleRepository.GetPermissionsSelected(role.IdRole);

                return View(role);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        [HttpGet]
        [Route("/Rol/Eliminar/{id:int}")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Delete-Role-Policy")]
        public async Task<IActionResult> Delete(int id)
        {
            Role role = await roleRepository.GetRoleWithPermissions(id);

            return View(role);
        }

        [HttpPost]
        [Route("/Rol/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                bool result = await roleRepository.DeleteRole(id);

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
