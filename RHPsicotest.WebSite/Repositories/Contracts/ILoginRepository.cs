using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ILoginRepository
    {
        public Task<(User, List<string>)> GetUserLogin(Login login);
        public Task<(Candidate, List<string>)> GetCandidateLogin(Login login);
    }
}
