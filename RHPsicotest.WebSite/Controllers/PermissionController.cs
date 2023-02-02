using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace RHPsicotest.WebSite.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IPermissionRepository permissionRepository;

        public PermissionController(IPermissionRepository permissionRepository)
        {
            this.permissionRepository = permissionRepository;
        }

        [Route("/Permisos")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Permission> permissions = await permissionRepository.GetAllPermissions();

            return View(permissions);
        }

        [Route("/Permiso/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            Permission permission = await permissionRepository.GetPermission(id);

            return View(permission);
        }

        [HttpGet]
        [Route("/Permiso/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/Permiso/Crear")]
        public async Task<IActionResult> Create(Permission _permission)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Permission permission = await permissionRepository.AddPermission(_permission);

                    if (permission != null)
                    {
                        return RedirectToAction("Index", "Permission");
                    }
                }

                return View(_permission);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Permiso/Editar/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            Permission permission = await permissionRepository.GetPermission(id);

            return View(permission);
        }

        [HttpPost]
        [Route("/Permiso/Editar/{id:int}")]
        public async Task<IActionResult> Edit(Permission permission, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await permissionRepository.UpdatePermission(permission);

                    if (result)
                    {
                        return RedirectToAction("Index", "Permission");
                    }
                }

                return View(permission);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Permiso/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            Permission permission = await permissionRepository.GetPermission(id);

            return View(permission);
        }

        [HttpPost]
        [Route("/Permiso/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                bool result = await permissionRepository.DeletePermission(id);

                if (result)
                {
                    return RedirectToAction("Index", "Permission");
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
