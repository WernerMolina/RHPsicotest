using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Net;
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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, 
            Policy = "List-User-Policy")]
        public async Task<IActionResult> Index()
        {
            List<User> users = await userRepository.GetAllUsers();

            return View(users);
        }

        [HttpGet]
        [Route("/Usuario/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, 
            Policy = "Create-User-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Roles = await userRepository.GetAllRoles();

            return View();
        }

        [HttpPost]
        [Route("/Usuario/Crear")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Create-User-Policy")]
        public async Task<IActionResult> Create(UserVM userVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool userExists = await userRepository.UserExists(userVM.Email.Trim().ToUpper());

                    if (userExists)
                    {
                        ViewBag.Message = "El correo del usuario ya esta registrado";
                    }
                    else
                    {
                        bool result = await userRepository.AddUser(userVM);

                        if (result)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo guardar el usuario, intentelo después";
                        }
                    }
                }

                ViewBag.Roles = await userRepository.GetAllRoles();

                return View(userVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.Roles = await userRepository.GetAllRoles();

                return View(userVM);
            }
        }

        [HttpGet]
        [Route("/Usuario/Editar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Edit-User-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            UserUpdateVM userUpdateVM = await userRepository.GetUserUpdate(id);

            ViewBag.Roles = await userRepository.GetAllRoles();

            return View(userUpdateVM);
        }

        [HttpPost]
        [Route("/Usuario/Editar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Edit-User-Policy")]
        public async Task<IActionResult> Edit(UserUpdateVM userUpdateVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool userExists = await userRepository.UserExists(userUpdateVM.Email.Trim().ToUpper(), userUpdateVM.IdUser);

                    if (userExists)
                    {
                        ViewBag.Message = "El correo del usuario ya esta registrado";
                    }
                    else
                    {
                        bool result = await userRepository.UpdateUser(userUpdateVM);

                        if (result)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = "No se pudo actualizar el usuario, intentelo después";
                        }
                    }
                }

                ViewBag.Roles = await userRepository.GetAllRoles();

                return View(userUpdateVM);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                ViewBag.Roles = await userRepository.GetAllRoles();

                return View(userUpdateVM);
            }
        }

        [HttpPost]
        [Route("/Usuario/Eliminar")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "Delete-User-Policy")]
        public async Task<IActionResult> Delete(int userId)
        {
            try
            {
                bool result = await userRepository.DeleteUser(userId);

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
