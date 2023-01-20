using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IPermissionRepository
    {
        public Task<IEnumerable<Permission>> GetAllPermissions();

        public Task<Permission> GetPermission(int id);

        public Task<Permission> AddPermission(Permission permission);

        public Task<bool> UpdatePermission(Permission permission);

        public Task<bool> DeletePermission(int id);
    }
}
