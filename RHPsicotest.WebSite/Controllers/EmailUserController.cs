using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class EmailUserController : Controller
    {
        private readonly IEmailUserRepository emailUserRepository;
        private readonly IConfiguration configuration;

        public EmailUserController(IEmailUserRepository emailUserRepository, IConfiguration configuration)
        {
            this.emailUserRepository = emailUserRepository;
            this.configuration = configuration;
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
                    string html = configuration["E-Mail:EmailHtml"];
                    string username = configuration["E-Mail:Username"];
                    string password = configuration["E-Mail:Password"];

                    string email = string.Format(html, user.Password);

                    SendEmail send = new SendEmail(username, password);

                    send.Send(user.Email, email);

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
    }
}
