using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
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
        public async Task<IActionResult> Test1(string[][] response)
        {
            ViewBag.response = response;
            Test test = await testRepository.GetTest();

            //var result = await testRepository.GenerateResults(response);

            return View();
        }
    }
}
