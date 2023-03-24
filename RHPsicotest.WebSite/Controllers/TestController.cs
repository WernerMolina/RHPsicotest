using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Tests.Questions;
using System;
using System.Collections.Generic;
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
        public IActionResult Test_PPGIPG()
        {
            List<PPGIPG> test = testRepository.GetTest_PPGIPG();

            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/PPG-IPG")]
        public async Task<IActionResult> Test_PPGIPG(char[][] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            (bool, byte[], byte[]) results = await testRepository.Test_PPGIPG(responses, currentIdUser);

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

                List<PPGIPG> test = testRepository.GetTest_PPGIPG();

                return View(test);
            }

            return View();
        }
        
        [HttpGet]
        [Route("/Prueba/OTIS")]
        public IActionResult Test_OTIS()
        {
            List<OTIS> test = testRepository.GetTest_OTIS();

            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/OTIS")]
        public async Task<IActionResult> Test_OTIS(char[] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            //(bool, byte[], byte[]) results = ;

            //if (results.Item1)
            //{
            //    ViewBag.Factores = new string[]
            //    {
            //        "Ascendencia",
            //        "Responsabilidad",
            //        "Estabilidad Emocional",
            //        "Sociabilidad",
            //        "Cautela",
            //        "Originalidad",
            //        "Comprensión",
            //        "Vitalidad",
            //        "Autoestima",
            //    };

            //    ViewBag.Puntajes = results.Item2;
            //    ViewBag.Percentiles = results.Item3;


                return View();
        }

        [HttpGet]
        [Route("/Prueba/Dominos")]
        public IActionResult Test_Dominos()
        {
            List<Dominos> test = testRepository.GetTest_Dominos();

            return View(test);
        }

        [HttpPost]
        [Route("/Prueba/Dominos")]
        public async Task<IActionResult> Test_Dominos(char[][] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            (bool, byte[], byte[]) results = await testRepository.Test_PPGIPG(responses, currentIdUser);

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

                List<PPGIPG> test = testRepository.GetTest_PPGIPG();

                return View(test);
            }

            return View();
        }

    }
}
