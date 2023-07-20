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
        public async Task<IActionResult> Create(RoleVM roleVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    roleVM.RoleName = roleVM.RoleName.Trim();

                    bool roleExists = await roleRepository.RoleExists(roleVM.RoleName);

                    if (roleExists)
                    {
                        ViewBag.Message = "El nombre del rol ya esta registrado";
                    }
                    else
                    {
                        bool result = await roleRepository.AddRole(roleVM);

                        if (result)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo guardar el rol, intentelo después";
                        }
                    }
                }

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(roleVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(roleVM);
            }
        }

        [HttpGet]
        [Route("/Rol/Editar")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Edit-Role-Policy")]
        public async Task<IActionResult> Edit(int roleId)
        {
            RoleUpdateVM role = await roleRepository.GetRoleUpdate(roleId);

            if (role == null) return RedirectToAction(nameof(Index));

            ViewBag.Permissions = await roleRepository.GetAllPermissions();

            return View(role);
        }

        [HttpPost]
        [Route("/Rol/Editar")]
        public async Task<IActionResult> Edit(RoleUpdateVM roleUpdateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    roleUpdateVM.RoleName = roleUpdateVM.RoleName.Trim();

                    bool roleExists = await roleRepository.RoleExists(roleUpdateVM.RoleName, roleUpdateVM.IdRole);

                    if (roleExists)
                    {
                        ViewBag.Message = "El nombre del rol ya esta registrado";
                    }
                    else
                    {
                        bool result = await roleRepository.UpdateRole(roleUpdateVM);

                        if (result)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo actualizar el rol, intentelo después";
                        }
                    }
                }

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(roleUpdateVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.Permissions = await roleRepository.GetAllPermissions();

                return View(roleUpdateVM);
            }
        }

        [HttpPost]
        [Route("/Rol/Eliminar")]
        public async Task<IActionResult> Delete(int roleId)
        {
            try
            {
                bool result = await roleRepository.DeleteRole(roleId);

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
