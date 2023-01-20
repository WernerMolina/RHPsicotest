using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<MultiSelectList> GetAllPermissions()
        {
            var permissions = await context.Permissions.ToListAsync();

            return new MultiSelectList(permissions, "IdPermission", "PermissionName");
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await context.Roles.Include("Permissions.Permission").ToListAsync();
        }

        private async Task<Role> GetRole(int id)
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.IdRole == id);
        }
        
        public async Task<Role> GetRoleWithPermissions(int id)
        {
            return await context.Roles.Include("Permissions.Permission").FirstOrDefaultAsync(r => r.IdRole == id);
        }

        public async Task<Role> AddRole(Role role, List<int> permisssions)
        {
            bool roleExists = await RoleExists(role);

            if (!roleExists)
            {
                var result = await context.Roles.AddAsync(role);
                await context.SaveChangesAsync();

                AddPermission_Role(role.IdRole, permisssions);

                return result.Entity;
            }
            
            return null;
        }

        private void AddPermission_Role(int roleId, List<int> permissions, bool delete = false)
        {
            if (delete)
            {
                var permissionsRole = context.Permission_Roles.Where(pr => pr.IdRole == roleId).ToList();

                context.Permission_Roles.RemoveRange(permissionsRole);
                context.SaveChanges();
            }

            foreach (int id in permissions)
            {
                context.Permission_Roles.Add(new Permission_Role
                {
                    IdRole = roleId,
                    IdPermission = id
                });
            }

            context.SaveChanges();
        }

        private async Task<bool> RoleExists(Role role)
        {
            return await context.Roles.AnyAsync(r => r.RoleName == role.RoleName);
        }
        
        public  async Task<bool> UpdateRole(Role role, List<int> permissions)
        {
            var _role = await context.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.RoleName == role.RoleName);
            
            bool result = false;

            if (_role == null || role.IdRole == _role.IdRole)
            {
                context.Roles.Update(role);
                result = await context.SaveChangesAsync() > 0;

                AddPermission_Role(role.IdRole, permissions, true);
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

        public async Task<MultiSelectList> GetPermissionsSelected(int roleId)
        {
            var role = await GetRoleWithPermissions(roleId);
            var permissionsRole = role.Permissions;
            var permissions = await context.Permissions.ToListAsync();
            
            List<int> selectedPermissions = new List<int>();

            foreach (var permission in permissionsRole)
            {
                selectedPermissions.Add(permission.IdPermission);
            }

            return new MultiSelectList(permissions, "IdPermission", "PermissionName", selectedPermissions);
        }

    }
}
