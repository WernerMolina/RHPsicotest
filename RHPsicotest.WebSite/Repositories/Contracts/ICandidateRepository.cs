using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ICandidateRepository
    {
        public Task<IEnumerable<Candidate>> GetAllEmailUsers();

        public Task<IEnumerable<Stall>> GetAllStalls();

        public Task<CandidateSendDTO> AddEmailUser(CandidateVM candidateVM);

        public Task<Role> GetRoleName();

        public Task<CandidateDTO> GetCandidateLogin(CandidateLogin candidateLogin);
    }
}
