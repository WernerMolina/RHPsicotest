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
    }
}
