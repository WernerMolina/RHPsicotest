using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Route("/Usuarios")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public async Task<IActionResult> Index()
        {
            List<UserDTO> users = await userRepository.GetAllUsers();

            return View(users);
        }
        
        [HttpGet]
        [Route("/Usuario/Crear")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Roles = await userRepository.GetAllRoles();

            return View();
        }

        [HttpPost]
        [Route("/Usuario/Crear")]
        public async Task<IActionResult> Create(UserVM user, List<int> rolesId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await userRepository.AddUser(user, rolesId);

                    if (result)
                    {
                        return RedirectToAction("Index", "user");
                    }
                }

                ViewBag.Roles = await userRepository.GetAllRoles();

                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Usuario/Editar")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Edit-User-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            (UserUpdateVM, MultiSelectList) user = await userRepository.GetUserAndRolesSelected(id);

            ViewBag.Roles = user.Item2;

            return View(user.Item1);
        }

        [HttpPost]
        [Route("/Usuario/Editar")]
        public async Task<IActionResult> Edit(UserUpdateVM user, List<int> rolesId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool result = await userRepository.UpdateUser(user, rolesId);

                    if (result)
                    {
                        return RedirectToAction("Index", "user");
                    }
                }

                ViewBag.Roles = await userRepository.GetRolesSelected(rolesId);

                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("/Usuario/Eliminar")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool result = await userRepository.DeleteUser(id);

                if (result)
                {
                    return RedirectToAction("Index", "User");
                }

                return RedirectToAction("Index", "User");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
