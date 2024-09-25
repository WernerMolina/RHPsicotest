using RHPsicotest.WebSite.ViewModels;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ILoginRepository
    {
        Task<(ClaimsIdentity, bool, bool)> GetAuthentication(Login userLogin);
    }
}
