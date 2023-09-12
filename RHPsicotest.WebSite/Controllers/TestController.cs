using Microsoft.AspNetCore.Authentication.Cookies;
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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Policy = "AssignedTests-Test-Policy")]
        public async Task<IActionResult> AssignedTests()
        {
            int userId = GetCandidateId();

            if (userId > 0)
            {
                List<TestDTO> assignedTests = await testRepository.GetAssignedTests(userId);

                ViewBag.Message = TempData["message"];

                return View(assignedTests);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        [Route("/Prueba/PPG-IPG")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Roles = "Candidato")]
        public async Task<IActionResult> Test_PPGIPG()
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("PPG-IPG");

            bool isCompleted = await testRepository.HasCompleteTest(userId, testId);

            if (isCompleted)
            {
                TempData["message"] = "Ya has completado la prueba PPG-IPG";

                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_PPGIPG> test = testRepository.GetQuestions_Test_PPGIPG();

            return View(test);
        }

        [HttpPost]
        [Route("/Prueba/PPG-IPG")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Roles = "Candidato")]
        public async Task<IActionResult> Test_PPGIPG(char[][] responses)
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("PPG-IPG");

            bool result = await testRepository.GenerateResults_Test_PPGIPG(responses, userId, testId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_PPGIPG> test = testRepository.GetQuestions_Test_PPGIPG();

            return View(test);
        }

        [HttpGet]
        [Route("/Prueba/OTIS")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Roles = "Candidato")]
        public async Task<IActionResult> Test_OTIS()
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("OTIS");

            bool isCompleted = await testRepository.HasCompleteTest(userId, testId);

            if (isCompleted)
            {
                TempData["message"] = "Ya has completado la prueba OTIS";

                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_OTIS> test = testRepository.GetQuestions_Test_OTIS();

            return View(test);
        }

        [HttpPost]
        [Route("/Prueba/OTIS")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Roles = "Candidato")]
        public async Task<IActionResult> Test_OTIS(char[] responses)
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("OTIS");

            bool result = await testRepository.GenerateResults_Test_OTIS(responses, userId, testId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_OTIS> test = testRepository.GetQuestions_Test_OTIS();

            return View(test);
        }

        [HttpGet]
        [Route("/Prueba/Dominos")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Roles = "Candidato")]
        public async Task<IActionResult> Test_Dominos()
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("Dominos");

            bool isCompleted = await testRepository.HasCompleteTest(userId, testId);

            if (isCompleted)
            {
                TempData["message"] = "Ya has completado la prueba Dominos";

                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }

        [HttpPost]
        [Route("/Prueba/Dominos")]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme,
            Roles = "Candidato")]
        public async Task<IActionResult> Test_Dominos(char?[][] responses)
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("Dominos");

            bool result = await testRepository.GenerateResults_Test_Dominos(responses, userId, testId);

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
            int userId = GetCandidateId();

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
            int userId = GetCandidateId();
            int testId = await GetTestId("16PF-A");

            bool result = await testRepository.GenerateResults_Test_16PF(responses, userId, testId, true);

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
            int userId = GetCandidateId();
            int testId = await GetTestId("16PF-B");

            bool result = await testRepository.GenerateResults_Test_16PF(responses, userId, testId, false);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }

        [HttpGet]
        [Route("/Prueba/IPV")]
        public async Task<IActionResult> Test_IPV()
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("IPV");

            bool isCompleted = await testRepository.HasCompleteTest(userId, testId);

            if (isCompleted)
            {
                TempData["message"] = "Ya has completado la prueba IPV";

                return RedirectToAction(nameof(AssignedTests));
            }

            List<Questions_IPV> questions = testRepository.GetQuestions_Test_IPV();

            return View(questions);
        }

        [HttpPost]
        [Route("/Prueba/IPV")]
        public async Task<IActionResult> Test_IPV(char[] responses)
        {
            int userId = GetCandidateId();
            int testId = await GetTestId("IPV");

            bool result = await testRepository.GenerateResults_Test_IPV(responses, userId, testId);

            if (result)
            {
                return RedirectToAction(nameof(AssignedTests));
            }

            return View();
        }


        private int GetCandidateId()
        {
            return Convert.ToInt32(((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        private async Task<int> GetTestId(string testName)
        {
            return await testRepository.GetTestId(testName);
        }
    }
}
