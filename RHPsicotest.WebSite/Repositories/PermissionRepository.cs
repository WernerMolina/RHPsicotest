using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly RHPsicotestDbContext context;

        public PermissionRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            return await context.Permissions.ToListAsync();
        }
    }
}
