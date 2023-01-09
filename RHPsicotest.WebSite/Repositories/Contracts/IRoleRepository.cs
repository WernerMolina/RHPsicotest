using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IRoleRepository
    {
        public Task<IEnumerable<Role>> GetAllRoles();

        public Task<IEnumerable<Permission>> GetAllPermissions();

        public Task<Role> GetRole(int id);

        public Task<Role> AddRole(Role role);

        public Task<bool> UpdateRole(Role role);

        public Task<bool> DeleteRole(int id);
    }
}
