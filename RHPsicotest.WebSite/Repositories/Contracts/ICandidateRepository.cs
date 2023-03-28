using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.ViewModels.Candidate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ICandidateRepository
    {
        public Task<IEnumerable<CandidateDTO>> GetAllCandidates();

        public Task<IEnumerable<Position>> GetAllPositions();

        public Task<CandidateSendVM> AddCandidate(CandidateVM candidateVM);

        public Task<Role> GetRoleName();

        public Task<List<string>> GetTestNames(int positionId);

    }
}
