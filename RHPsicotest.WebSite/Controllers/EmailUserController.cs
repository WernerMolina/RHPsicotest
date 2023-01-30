using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    public class EmailUserController : Controller
    {
        private readonly IEmailUserRepository emailUserRepository;

        public EmailUserController(IEmailUserRepository emailUserRepository)
        {
            this.emailUserRepository = emailUserRepository;
        }

        [HttpGet]
        [Route("/Contraseñas")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<EmailUser> users = await emailUserRepository.GetAllEmailUsers();

            return View(users);
        }
        
        [HttpGet]
        [Route("/EnviarCorreo")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public IActionResult SendMail(EmailUserSendDTO user, string nothing = null)
        {
            return View(user);
        }
        
        [HttpPost]
        [Route("/EnviarCorreo")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "List-Users-Policy")]
        public IActionResult SendMail(EmailUserSendDTO user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SendEmail.Send(user.Email, user.Password);

                    return RedirectToAction("Index", "EmailUser");
                }

                return View(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Contraseña/Crear")]
        //[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Policy = "Create-User-Policy")]
        public async Task<IActionResult> Create()
        {
            ViewBag.Role = await emailUserRepository.GetRoleName();
            ViewBag.Stalls = await emailUserRepository.GetAllStalls();

            return View();
        }

        [HttpPost]
        [Route("/Contraseña/Crear")]
        public async Task<IActionResult> Create(EmailUserVM emailUserVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmailUserSendDTO userSendDTO = await emailUserRepository.AddEmailUser(emailUserVM);

                    if (userSendDTO != null)
                    {
                        return RedirectToAction("SendMail", "EmailUser", userSendDTO);
                    }
                }

                ViewBag.Role = await emailUserRepository.GetRoleName();
                ViewBag.Stalls = await emailUserRepository.GetAllStalls();

                return View(emailUserVM);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("/Candidato/Login")]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [Route("/Candidato/Login")]
        public async Task<IActionResult> Login(CandidateLogin candidateLogin)
        {
            if (ModelState.IsValid)
            {
                EmailUserDTO emailUserDTO = await emailUserRepository.GetCandidateLogin(candidateLogin);

                if (emailUserDTO != null)
                {
                    ClaimsIdentity identity = Helper.CandidateAuthenticate(emailUserDTO);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                    return RedirectToAction("ConfirmPolicies", "Expedient");
                }
            }

            candidateLogin.Password = string.Empty;

            return View(candidateLogin);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
