using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly RHPsicotestDbContext context;

        public CandidateRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<CandidateSendVM> AddCandidate(CandidateVM candidateVM)
        {
            bool result;

            Candidate candidate = Conversion.ConvertToCandidate(candidateVM);

            await context.Candidates.AddAsync(candidate);
            result = await context.SaveChangesAsync() > 0;

            if (result)
            {
                AddTestsToCandidate(candidate.IdPosition, candidate.IdCandidate);

                return Conversion.ConvertToCandidateSendVM(candidateVM);
            }

            return null;
        }

        public async Task<CandidateResendMailVM> GetCandidateResendMailVM(int candidateId)
        {
            Candidate candidate = await context.Candidates.FirstOrDefaultAsync(c => c.IdCandidate == candidateId);

            if (candidate != null)
            {
                List<Test_Candidate> testCandidates = await context.Test_Candidates.Where(t => t.IdCandidate == candidateId).Include(t => t.Test).ToListAsync();

                List<Test> tests = new List<Test>();

                foreach (Test_Candidate test in testCandidates)
                {
                    tests.Add(test.Test);
                }

                CandidateResendMailVM candidateResendMailVM = Conversion.ConvertToCandidateResendMailVM(candidate, tests);

                return candidateResendMailVM;
            }

            return null;
        }

        public async Task<List<CandidateDTO>> GetAllCandidates()
        {
            List<Candidate> candidates = await context.Candidates.Include(c => c.Position).OrderByDescending(c => c.IdCandidate).ToListAsync();

            List<CandidateDTO> candidateDTOs = new List<CandidateDTO>();

            foreach (Candidate candidate in candidates)
            {
                candidateDTOs.Add(Conversion.ConvertToCandidateDTO(candidate));
            }

            return candidateDTOs;
        }

        public async Task<List<Position>> GetAllPositions()
        {
            return await context.Positions.ToListAsync();
        }

        public async Task<bool> DeleteResultsToCandidate(int candidateId, List<int> testsId)
        {
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            //foreach (int testId in testsId)
            //{
            //    List<Result> results = await context.Results.Where(r => r.IdExpedient == expedient.IdExpedient && r.IdTest == testId).ToListAsync();

            //    context.Results.RemoveRange(results);
            //    context.SaveChanges();
            //}

            foreach (int id in testsId)
            {
                Test_Candidate candidate = await context.Test_Candidates.FirstOrDefaultAsync(c => c.IdCandidate == candidateId && c.IdTest == id);

                candidate.Status = false;

                context.Test_Candidates.Update(candidate);
            }

            return context.SaveChanges() > 0;
        }

        public async Task<Role> GetRoleName()
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.RoleName == "Candidato");
        }

        public async Task<List<string>> GetTestNames(int positionId)
        {
            Position position = await context.Positions.Include(p => p.Tests).FirstOrDefaultAsync(p => p.IdPosition == positionId);

            List<string> testNames = new List<string>();

            foreach (Test_Position testPosition in position.Tests)
            {
                Test test = await context.Tests.FirstOrDefaultAsync(t => t.IdTest == testPosition.IdTest);

                testNames.Add(test.NameTest);
            }

            return testNames;
        }

        public async Task<bool> CandidateExists(string email, int id = 0)
        {
            if (id > 0)
            {
                Candidate candidate = await context.Candidates.AsNoTracking().FirstOrDefaultAsync(u => u.EmailNormalized == email);

                if (candidate != null)
                {
                    return !(candidate.IdCandidate == id && candidate.EmailNormalized == email);
                }

                return false;
            }

            return await context.Candidates.AnyAsync(r => r.EmailNormalized == email); ;
        }

        private void AddTestsToCandidate(int positionId, int candidateId)
        {
            List<Test_Position> tests = context.Test_Positions.AsNoTracking().Where(t => t.IdPosition == positionId).ToList();

            foreach (Test_Position test in tests)
            {
                context.Test_Candidates.Add(new Test_Candidate
                {
                    IdTest = test.IdTest,
                    IdCandidate = candidateId,
                    Status = false
                });
            }

            context.SaveChanges();
        }
    }
}
