using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Repositories.Contracts;
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
                    (ClaimsIdentity, bool, bool) result = await loginRepository.GetAuthentication(userLogin);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(result.Item1));

                    if (result.Item3)
                        return RedirectToAction("AssignedTests", "Test");
                    else if (result.Item2)
                        return RedirectToAction("ConfirmPolicies", "Expedient");
                    else
                        return RedirectToAction("Dashboard", "Home");
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
