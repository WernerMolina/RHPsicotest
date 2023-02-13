using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestRepository testRepository;

        public TestController(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }

        [HttpGet]
        [Route("/Indicaciones")]
        public IActionResult Indications()
        {
            return View();
        }

        [HttpGet]
        [Route("/Prueba/PPG-IPG")]
        public async Task<IActionResult> Test1()
        {
            Test test = await testRepository.GetTest();


            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/PPG-IPG")]
        public async Task<IActionResult> Test1(char[][] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            (bool, byte[], byte[]) results = await testRepository.TestPPG_IPG(responses, currentIdUser);

            if (results.Item1)
            {
                ViewBag.Factores = new string[]
                {
                    "Ascendencia",
                    "Responsabilidad",
                    "Estabilidad Emocional",
                    "Sociabilidad",
                    "Cautela",
                    "Originalidad",
                    "Comprensión",
                    "Vitalidad",
                    "Autoestima",
                };

                ViewBag.Puntajes = results.Item2;
                ViewBag.Percentiles = results.Item3;

                Test test = await testRepository.GetTest();

                return View(test);
            }

            return View();
        }
    }
}
