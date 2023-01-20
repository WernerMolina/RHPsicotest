using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IRoleRepository
    {
        public Task<IEnumerable<Role>> GetAllRoles();

        public Task<MultiSelectList> GetAllPermissions();

        public Task<Role> GetRoleWithPermissions(int id);

        public Task<Role> AddRole(Role role, List<int> permissions);

        public Task<bool> UpdateRole(Role role, List<int> permissions);

        public Task<bool> DeleteRole(int id);

        public Task<MultiSelectList> GetPermissionsSelected(int id);
    }
}
