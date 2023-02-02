using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
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
            IEnumerable<User> users = await userRepository.GetAllUsers();

            return View(users);
        }
        
        [HttpGet]
        [Route("/Usuarioss")]
        public async Task<IActionResult> Indexs()
        {
            IEnumerable<User> users = await userRepository.GetAllUsers();

            string json = JsonConvert.SerializeObject(users, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return Ok(json);
        }

        [HttpGet]
        [Route("/Usuario/Detalles/{id:int}")]
        public async Task<IActionResult> Details(int id)
        {
            UserDTO user = await userRepository.GetUserDTO(id);

            return View(user);
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
        public async Task<IActionResult> Create(User _user, List<int> roles)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    User user = await userRepository.AddUser(_user, roles);

                    if (user != null)
                    {
                        return RedirectToAction("Index", "user");
                    }
                }

                return View(_user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Usuario/Editar/{id:int}")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Edit-User-Policy")]
        public async Task<IActionResult> Edit(int id)
        {
            UserDTO user = await userRepository.GetUserDTO(id);
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
                    bool result = await userRepository.UpdateUser(user, roles);

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
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Delete-User-Policy")]
        public async Task<IActionResult> Delete(int id)
        {
            UserDTO user = await userRepository.GetUserDTO(id);

            return View(user);
        }

        [HttpPost]
        [Route("/Usuario/Eliminar/{id:int}")]
        public async Task<IActionResult> Delete(int id, string nothing)
        {
            try
            {
                bool result = await userRepository.DeleteUser(id);

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
        [Route("/Login")]
        public IActionResult Login(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [Route("/Login")]
        public async Task<IActionResult> Login(Login userLogin, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                userLogin.Password = Helper.EncryptMD5(userLogin.Password);

                UserDTO userDtO = await userRepository.GetUserLogin(userLogin);

                if (userDtO != null)
                {
                    ClaimsIdentity identity = Helper.Authenticate(userDtO);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    bool isAdmin = Helper.IsAdmin(userDtO);

                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            userLogin.Password = string.Empty;

            return View(userLogin);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
