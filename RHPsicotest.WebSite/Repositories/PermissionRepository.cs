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

        public async Task<Permission> AddPermission(Permission permission)
        {
            bool permissionExists = await PermissionExists(permission);

            if (!permissionExists)
            {
                var result = await context.Permissions.AddAsync(permission);
                await context.SaveChangesAsync();

                return result.Entity;
            }

            return null;
        }

        public async Task<bool> DeletePermission(int id)
        {
            var result = false;
            var permission = await GetPermission(id);

            if (permission != null)
            {
                context.Permissions.Remove(permission);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<IEnumerable<Module>> GetAllModules()
        {
            return await context.Modules.ToListAsync();
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            return await context.Permissions.Include(p => p.Module).ToListAsync();
        }

        public async Task<Permission> GetPermission(int id)
        {
            return await context.Permissions.AsNoTracking().Include(r => r.Module).FirstOrDefaultAsync(r => r.IdPermission == id);
        }

        public async Task<bool> UpdatePermission(Permission permission)
        {
            var _permission = await context.Permissions.AsNoTracking().FirstOrDefaultAsync(p => p.PermissionName == permission.PermissionName);

            bool result = false;

            if(_permission == null || _permission.IdPermission == permission.IdPermission)
            {
                context.Permissions.Update(permission);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        private async Task<bool> PermissionExists(Permission permission)
        {
            return await context.Permissions.AnyAsync(r => r.PermissionName == permission.PermissionName);
        }
    }
}
