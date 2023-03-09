using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.ViewModels.Role;
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
            List<Role> roles = await roleRepository.GetAllRoles();

            return View(roles);
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
        public async Task<IActionResult> Create(RoleVM role, List<int> permissionsId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await roleRepository.AddRole(role, permissionsId);

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
        [Route("/Rol/Editar")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Edit-Role-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            RoleUpdateVM role = await roleRepository.GetRoleUpdate(id);

            ViewBag.Permissions = await roleRepository.GetPermissionsSelected(id);

            return View(role);
        }

        [HttpPost]
        [Route("/Rol/Editar")]
        public async Task<IActionResult> Edit(RoleUpdateVM role, List<int> permissionsId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await roleRepository.UpdateRole(role, permissionsId);

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
        
        [HttpPost]
        [Route("/Rol/Eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool result = await roleRepository.DeleteRole(id);

                if(result)
                {
                    return RedirectToAction("Index", "Role");
                }

                return RedirectToAction("Index", "Role");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
