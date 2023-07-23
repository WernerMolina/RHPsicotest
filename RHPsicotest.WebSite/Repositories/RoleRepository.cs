using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
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


        public async Task<bool> AddRole(RoleVM roleVM)
        {
            bool result;

            Role role = Conversion.ConvertToRole(roleVM);

            await context.Roles.AddAsync(role);
            result = await context.SaveChangesAsync() > 0;

            if (result) AddPermissionsToRole(role.IdRole, roleVM.PermissionsId);

            return result;
        }

        public async Task<bool> UpdateRole(RoleUpdateVM roleUpdateVM)
        {
            bool result;

            Role role = Conversion.ConvertToRole(roleUpdateVM);

            context.Roles.Update(role);
            result = await context.SaveChangesAsync() > 0;

            if (result) AddPermissionsToRole(role.IdRole, roleUpdateVM.PermissionsId, true);

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

        public async Task<RoleUpdateVM> GetRoleUpdate(int roleId)
        {
            Role role = await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.IdRole == roleId);

            List<int> permissions = new List<int>();

            if (role != null)
            {
                foreach (Permission_Role permissionId in role.Permissions)
                {
                    permissions.Add(permissionId.IdPermission);
                }
            }

            RoleUpdateVM roleUpdateVM = Conversion.ConvertToRoleUpdateVM(role, permissions);

            return roleUpdateVM;
        }

        public async Task<List<Permission>> GetAllPermissions()
        {
            return await context.Permissions.ToListAsync(); ;
        }

        private void AddPermissionsToRole(int roleId, List<int> permissionsId, bool delete = false)
        {
            if (delete)
            {
                List<Permission_Role> permissionsRole = context.Permission_Roles.Where(pr => pr.IdRole == roleId).ToList();

                context.Permission_Roles.RemoveRange(permissionsRole);
                context.SaveChanges();
            }

            if (permissionsId != null)
            {
                foreach (int id in permissionsId)
                {
                    context.Permission_Roles.Add(new Permission_Role
                    {
                        IdRole = roleId,
                        IdPermission = id
                    });
                }

                context.SaveChanges();
            }
        }

        public async Task<bool> RoleExists(string roleName, int id = 0)
        {
            if (id > 0)
            {
                Role role = await context.Roles.AsNoTracking().FirstOrDefaultAsync(r => r.RoleNameNormalized == roleName);

                if (role != null)
                {
                    return !(role.IdRole == id && role.RoleNameNormalized == roleName);
                }

                return false;
            }

            return await context.Roles.AnyAsync(r => r.RoleNameNormalized == roleName); ;
        }


    }
}
