using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        [HttpGet]
        //[Route("/Login")]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Candidato"))
                {
                    return RedirectToAction("Create", "Expedient");
                }

                return RedirectToAction("Dashboard", "Home");
            }

            return View();
        }

        [HttpPost]
        [Route("/Login")]
        public async Task<IActionResult> Login(Login userLogin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ClaimsIdentity identity;

                    if (userLogin.IsCandidate)
                    {
                        bool emailCandidateExists = await loginRepository.EmailExists(userLogin.Email, true);

                        if (!emailCandidateExists)
                        {
                            ViewBag.Error = "El correo no esta registrado";

                            return View(userLogin);
                        }

                        CandidateLoginDTO candidateLoginDTO = await loginRepository.GetCandidateLogin(userLogin);

                        if (candidateLoginDTO == null)
                        {
                            ViewBag.Error = "La contraseña es incorrecta";

                            return View(userLogin);
                        }

                        identity = Helper.CandidateAuthenticate(candidateLoginDTO);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                        if (candidateLoginDTO.HasExpediente)
                        {
                            return RedirectToAction("AssignedTests", "Test");
                        }
                        else
                        {
                            return RedirectToAction("ConfirmPolicies", "Expedient");
                        }
                    }
                    else
                    {
                        bool emailCandidateExists = await loginRepository.EmailExists(userLogin.Email, true);

                        if (emailCandidateExists)
                        {
                            ViewBag.Error = "Por favor, haga clic en el checkbox de arriba, que indica que es un candidato";

                            return View(userLogin);
                        }

                        bool emailExists = await loginRepository.EmailExists(userLogin.Email, false);

                        if (!emailExists)
                        {
                            ViewBag.Error = "El correo no esta registrado";

                            return View(userLogin);
                        }

                        UserLoginDTO userLoginDTO = await loginRepository.GetUserLogin(userLogin);

                        if (userLoginDTO == null)
                        {
                            ViewBag.Error = "La contraseña es incorrecta";

                            return View(userLogin);
                        }

                        identity = Helper.UserAuthenticate(userLoginDTO);

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                        return RedirectToAction("Dashboard", "Home");
                    }
                }

                return View(userLogin);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;

                return View(userLogin);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Login");
        }

    }
}
