using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IPermissionRepository
    {
        public Task<IEnumerable<Permission>> GetAllPermissions();
    }
}
