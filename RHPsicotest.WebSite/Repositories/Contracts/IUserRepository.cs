using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IUserRepository
    {
        public Task<User> GetUserLogin(Login userLogin);
    }
}
