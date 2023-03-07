using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels.Role;
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


        public async Task<bool> AddRole(RoleVM roleVM, List<int> permisssions)
        {
            bool result = false;
            
            bool roleExists = await RoleExists(roleVM.RoleName);

            if (!roleExists)
            {
                Role role = Conversion.ConvertToRole(roleVM);

                await context.Roles.AddAsync(role);
                result = await context.SaveChangesAsync() > 0;

                if (result) PermissionsAsing(role.IdRole, permisssions);
            }

            return result;
        }

        public async Task<bool> UpdateRole(RoleUpdateVM roleUpdateVM, List<int> permissions)
        {
            bool result = false;

            Role roleExist = await context.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.RoleName == roleUpdateVM.RoleName);

            if (roleExist == null || roleExist.IdRole == roleUpdateVM.IdRole)
            {
                Role role = Conversion.ConvertToRole(roleUpdateVM);

                context.Roles.Update(role);
                result = await context.SaveChangesAsync() > 0;

                if (result) PermissionsAsing(role.IdRole, permissions, true);
            }

            return result;
        }

        public async Task<bool> DeleteRole(int roleId)
        {
            bool result = false;

            Role role = await context.Roles.FirstOrDefaultAsync(r => r.IdRole == roleId);

            if (role != null)
            {
                context.Roles.Remove(role);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await context.Roles.Include("Permissions.Permission").ToListAsync();
        }

        public async Task<RoleUpdateVM> GetRoleUpdate(int id)
        {
            Role role = await context.Roles.FirstOrDefaultAsync(r => r.IdRole == id);

            RoleUpdateVM roleUpdateVM = Conversion.ConvertToRoleUpdateVM(role);

            return roleUpdateVM;
        }


        public async Task<MultiSelectList> GetAllPermissions()
        {
            List<Permission> permissions = await context.Permissions.ToListAsync();

            return new MultiSelectList(permissions, "IdPermission", "PermissionName");
        }


        public async Task<MultiSelectList> GetPermissionsSelected(int roleId)
        {
            Role role = await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(u => u.IdRole == roleId);

            List<Permission> permissions = await context.Permissions.ToListAsync();
            
            List<int> selectedPermissions = new List<int>();

            foreach (var permission in role.Permissions)
            {
                selectedPermissions.Add(permission.IdPermission);
            }

            return new MultiSelectList(permissions, "IdPermission", "PermissionName", selectedPermissions);
        }


        //-------------------------------
        private void PermissionsAsing(int roleId, List<int> permissions, bool delete = false)
        {
            if (delete)
            {
                List<Permission_Role> permissionsRole = context.Permission_Roles.Where(pr => pr.IdRole == roleId).ToList();

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

        private async Task<bool> RoleExists(string roleName)
        {
            return await context.Roles.AnyAsync(r => r.RoleName == roleName);
        }


    }
}
