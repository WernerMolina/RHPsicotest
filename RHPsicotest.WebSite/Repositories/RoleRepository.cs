using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RHPsicotestDbContext context;

        public RoleRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await context.Roles.Include(r => r.Permission).ToListAsync();
        }
        
        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            return await context.Permissions.ToListAsync();
        }

        public async Task<Role> GetRole(int id)
        {
            return await context.Roles.Include(r => r.Permission).FirstOrDefaultAsync(r => r.IdRole == id);
        }

        public async Task<Role> AddRole(Role role)
        {
            bool roleExists = await RoleExists(role);

            if (!roleExists)
            {
                var result = await context.Roles.AddAsync(role);
                await context.SaveChangesAsync();

                return result.Entity;
            }
            
            return null;
        }

        private async Task<bool> RoleExists(Role role)
        {
            return await context.Roles.AnyAsync(r => r.RoleName == role.RoleName);
        }

        public  async Task<bool> UpdateRole(Role role)
        {
            var _role = await context.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.RoleName == role.RoleName);
            
            bool result = false;

            if (_role == null || role.IdRole == _role.IdRole)
            {
                context.Roles.Update(role);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<bool> DeleteRole(int id)
        {
            var result = false;
            var role = await GetRole(id);

            if(role != null)
            {
                context.Roles.Remove(role);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }
    }
}
