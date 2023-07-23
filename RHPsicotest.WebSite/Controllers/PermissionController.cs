using Microsoft.AspNetCore.Mvc;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IPermissionRepository permissionRepository;

        public PermissionController(IPermissionRepository permissionRepository)
        {
            this.permissionRepository = permissionRepository;
        }

        [Route("/Permisos")]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Permission> permissions = await permissionRepository.GetAllPermissions();

            return View(permissions);
        }
    }
}
