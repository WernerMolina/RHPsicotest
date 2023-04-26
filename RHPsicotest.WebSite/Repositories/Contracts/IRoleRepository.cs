using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels.Role;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IRoleRepository
    {
        public Task<bool> AddRole(RoleVM roleVM, List<int> permissions);

        public Task<bool> UpdateRole(RoleUpdateVM roleUpdateVM, List<int> permissions);

        public Task<bool> DeleteRole(int id);

        public Task<List<Role>> GetAllRoles();

        public Task<MultiSelectList> GetAllPermissions();

        public Task<RoleUpdateVM> GetRoleUpdate(int id);

        public Task<MultiSelectList> GetPermissionsSelected(int id);

        public Task<bool> RoleExists(string roleName, int id = 0);
    }
}
