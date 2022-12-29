using RHPsicotest.WebSite.Models;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IUserRepository
    {
        public Task<User> GetUserLogin(UserLogin userLogin);
    }
}
