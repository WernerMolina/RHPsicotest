using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ILoginRepository
    {
        public Task<UserLoginDTO> GetUserLogin(Login login);

        public Task<CandidateLoginDTO> GetCandidateLogin(Login login);

        public Task<bool> EmailExists(string email, bool isCandidate);
    }
}
