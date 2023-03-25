using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System.Security.Claims;
using System.Threading.Tasks;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System;

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
        public async Task<IActionResult> Login(Login userLogin, bool isCandidate, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            try
            {
                if (ModelState.IsValid)
                {
                    ClaimsIdentity identity;

                    if (isCandidate)
                    {
                        (Candidate, List<string>) candidate = await loginRepository.GetCandidateLogin(userLogin);

                        if (candidate.Item1 != null)
                        {
                            identity = Helper.CandidateAuthenticate(candidate.Item1, candidate.Item2);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                            if(candidate.Item1.Expedient != null)
                            {
                                return RedirectToAction("AssignedTests", "Test");
                            }
                            else
                            {
                                return RedirectToAction("ConfirmPolicies", "Expedient");
                            }
                        }
                    }
                    else
                    {
                        (User, List<string>) user = await loginRepository.GetUserLogin(userLogin);

                        if (user.Item1 != null)
                        {
                            identity = Helper.Authenticate(user.Item1, user.Item2);

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                            return RedirectToAction("Dashboard", "Home");
                        }
                    }
                }

                return View(userLogin);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

    }
}
