using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IMergeRepository merge;

        public PermissionController(IMergeRepository merge)
        {
            this.merge = merge;
        }

        [Route("/mergedb/{isTrue:bool}")]
        public async Task<IActionResult> Index(bool isTrue)
        {
            try
            {
                if (isTrue)
                    await merge.GenerateMergeDb();

                return Ok("Merge Success");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
