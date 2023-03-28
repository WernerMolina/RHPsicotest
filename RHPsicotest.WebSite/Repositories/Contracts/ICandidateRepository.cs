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
        public Task<List<CandidateDTO>> GetAllCandidates();

        public Task<List<Position>> GetAllPositions();

        public Task<bool> DeleteResults(int candidateId, List<int> testsId);

        public Task<CandidateSendVM> AddCandidate(CandidateVM candidateVM);

        public Task<CandidateResendMailVM> GetCandidateResendMailVM(int candidateId);

        public Task<Role> GetRoleName();

        public Task<List<string>> GetTestNames(int positionId);

    }
}
