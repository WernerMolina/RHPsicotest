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
        [Route("/PruebasAsignadas")]
        public async Task<IActionResult> AssignedTests()
        {
            int userId = GetCurrentUserId();

            List<TestDTO> tests = await testRepository.GetAssignedTests(userId);

            return View(tests);
        }

        [HttpGet]
        [Route("/Prueba/PPG-IPG")]
        public IActionResult Test_PPGIPG()
        {
            List<Questions_PPGIPG> test = testRepository.GetQuestions_Test_PPGIPG();

            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/PPG-IPG")]
        public async Task<IActionResult> Test_PPGIPG(char[][] responses)
        {
            int userId = GetCurrentUserId();

            bool result = await testRepository.GenerateResults_Test_PPGIPG(responses, userId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_PPGIPG> test = testRepository.GetQuestions_Test_PPGIPG();

            return View(test);
        }
        
        [HttpGet]
        [Route("/Prueba/OTIS")]
        public IActionResult Test_OTIS()
        {
            List<Questions_OTIS> test = testRepository.GetQuestions_Test_OTIS();

            return View(test);
        }
        
        [HttpPost]
        [Route("/Prueba/OTIS")]
        public async Task<IActionResult> Test_OTIS(char[] responses)
        {
            int userId = GetCurrentUserId();

            bool result = await testRepository.GenerateResults_Test_OTIS(responses, userId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_OTIS> test = testRepository.GetQuestions_Test_OTIS();

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
        public async Task<IActionResult> Test_Dominos(char?[][] responses)
        {
            int userId = GetCurrentUserId();

            bool result = await testRepository.GenerateResults_Test_Dominos(responses, userId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }

        [HttpGet]
        [Route("/Prueba/BFQ")]
        public IActionResult Test_BFQ()
        {
            List<Questions_BFQ> test = testRepository.GetQuestions_Test_BFQ();

            return View(test);
        }

        [HttpPost]
        [Route("/Prueba/BFQ")]
        public IActionResult Test_BFQ(char[][] responses)
        {
            int userId = GetCurrentUserId();

            return View();
        }
        
        [HttpGet]
        [Route("/Prueba/16PF-A")]
        public IActionResult Test_16PF_A()
        {
            List<Questions_16PF> questions = testRepository.GetQuestions_Test_16PF_A();

            return View(questions);
        }

        [HttpPost]
        [Route("/Prueba/16PF-A")]
        public async Task<IActionResult> Test_16PF_A(char[] responses)
        {
            int userId = GetCurrentUserId();

            bool result = await testRepository.GenerateResults_Test_16PF(responses, userId, true);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }
        
        [HttpGet]
        [Route("/Prueba/16PF-B")]
        public IActionResult Test_16PF_B()
        {
            List<Questions_16PF> questions = testRepository.GetQuestions_Test_16PF_B();

            return View(questions);
        }

        [HttpPost]
        [Route("/Prueba/16PF-B")]
        public async Task<IActionResult> Test_16PF_B(char[] responses)
        {
            int userId = GetCurrentUserId();

            bool result = await testRepository.GenerateResults_Test_16PF(responses, userId, false);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }
        
        [HttpGet]
        [Route("/Prueba/IPV")]
        public IActionResult Test_IPV()
        {
            List<Questions_IPV> questions = testRepository.GetQuestions_Test_IPV();

            return View(questions);
        }

        [HttpPost]
        [Route("/Prueba/IPV")]
        public async Task<IActionResult> Test_IPV(char[] responses)
        {
            int userId = GetCurrentUserId();

            bool result = await testRepository.GenerateResults_Test_IPV(responses, userId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }


        private int GetCurrentUserId()
        {
            return Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);
        }
    }
}
