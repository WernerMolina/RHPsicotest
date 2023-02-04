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
        public Task<IEnumerable<Candidate>> GetAllCandidates();

        public Task<IEnumerable<Stall>> GetAllStalls();

        public Task<CandidateSendDTO> AddCandidate(CandidateVM candidateVM);

        public Task<Role> GetRoleName();

        public Task<CandidateDTO> GetCandidateLogin(CandidateLogin candidateLogin);
    }
}
