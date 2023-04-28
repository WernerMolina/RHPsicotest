using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.DTOs;
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
        [Route("/PruebasAsignadas")]
        public async Task<IActionResult> AssignedTests()
        {
            int candidateId = Convert.ToInt16(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            List<TestDTO> tests = await testRepository.GetAssignedTests(candidateId);

            return View(tests);
        }

        [HttpGet]
        [Route("/Prueba/PPG-IPG")]
        public IActionResult Test_PPGIPG()
        {
            List<Questions_PPGIPG> test = testRepository.GetTest_PPGIPG();

            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/PPG-IPG")]
        public async Task<IActionResult> Test_PPGIPG(char[][] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            bool result = await testRepository.Test_PPGIPG(responses, currentIdUser);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_PPGIPG> test = testRepository.GetTest_PPGIPG();

            return View(test);
        }
        
        [HttpGet]
        [Route("/Prueba/OTIS")]
        public IActionResult Test_OTIS()
        {
            List<Questions_OTIS> test = testRepository.GetTest_OTIS();

            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/OTIS")]
        public async Task<IActionResult> Test_OTIS(char[] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            bool result = await testRepository.Test_OTIS(responses, currentIdUser);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_OTIS> test = testRepository.GetTest_OTIS();

            return View(test);
        }

        [HttpGet]
        [Route("/Prueba/Dominos")]
        public IActionResult Test_Dominos()
        {
            return View();
        }

        [HttpPost]
        [Route("/Prueba/Dominos")]
        public async Task<IActionResult> Test_Dominos(char[][] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            bool result = await testRepository.Test_Dominos(responses, currentIdUser);

            if (result)
            {
                return RedirectToAction("AssignedTests");
            }

            return View();
        }

        [HttpGet]
        [Route("/Prueba/BFQ")]
        public IActionResult Test_BFQ()
        {
            List<Questions_BFQ> test = testRepository.GetTest_BFQ();

            return View(test);
        }

        [HttpPost]
        [Route("/Prueba/BFQ")]
        public IActionResult Test_BFQ(char[][] responses)
        {
            int currentIdUser = Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);

            return View();
        }

    }
}
