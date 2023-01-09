using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
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

        [Route("/Usuarios")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<UserDTO> users = await userRepository.GetAllUsers();

            return View(users);
        }

        [Route("/Usuario/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            UserDTO user = await userRepository.GetUserWithRoles(id);

            return View(user);
        }

        [HttpGet]
        [Route("/Usuario/Crear")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Roles = await userRepository.GetAllRoles();

            return View();
        }

        [HttpPost]
        [Route("/Usuario/Crear")]
        public async Task<IActionResult> Create(User user, List<int> roles)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await userRepository.AddUser(user, roles);

                    if (result != null)
                    {
                        return RedirectToAction("Index", "user");
                    }
                }

                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Usuario/Editar/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            UserDTO user = await userRepository.GetUserWithRoles(id);
            ViewBag.Roles = await userRepository.GetRolesSelected(id);

            return View(user);
        }

        [HttpPost]
        [Route("/Usuario/Editar/{id:int}")]
        public async Task<IActionResult> Edit(UserDTO user, List<int> roles)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await userRepository.UpdateUser(user, roles);

                    if (result)
                    {
                        return RedirectToAction("Index", "user");
                    }

                }

                ViewBag.Roles = await userRepository.GetRolesSelected(user.IdUser);

                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Usuario/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            UserDTO user = await userRepository.GetUserWithRoles(id);

            return View(user);
        }

        [HttpPost]
        [Route("/Usuario/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                var result = await userRepository.DeleteUser(id);

                if (result)
                {
                    return RedirectToAction("Index", "user");
                }

                return View();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(Login userLogin, string returnUrl = null)
        //{
        //    ViewData["ReturnUrl"] = returnUrl;

        //    if (ModelState.IsValid)
        //    {
        //        Encryption.EncryptMD5(userLogin);

        //        var user = await userRepository.GetUserLogin(userLogin);

        //        if (user != null)
        //        {
        //            var claims = new[] { new Claim(ClaimTypes.Name, user.Email), 
        //                                 new Claim(ClaimTypes.user, user.userName) };
        //            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        //            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

        //            if (Url.IsLocalUrl(returnUrl))
        //            {
        //                return Redirect(returnUrl);
        //            }

        //            if (user.userName == "Administrador")
        //            {
        //                return RedirectToAction("Dashboard", "Home");
        //            }
        //            else
        //            {
        //                return RedirectToAction("Index", "Home");
        //            }
        //        }
        //    }

        //    return View(userLogin);
        //}

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
