using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.ViewModels.Candidate;
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
            bool passwordExists = await PasswordExist(candidateVM.Password);

            if (!passwordExists)
            {
                Candidate candidate = Conversion.ConvertToCandidate(candidateVM);

                await context.Candidates.AddAsync(candidate);
                await context.SaveChangesAsync();

                AssignTestsCandidate(candidate.IdPosition, candidate.IdCandidate);

                CandidateSendVM candidateSendVM = Conversion.ConvertToCandidateSendVM(candidateVM);

                return candidateSendVM;
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

                foreach (var test in testCandidates)
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
            List<Candidate> candidates = await context.Candidates.Include(c => c.Role).Include(c => c.Position).ToListAsync();

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
        
        public async Task<bool> DeleteResults(int candidateId, List<int> testsId)
        {
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            List<Result> results = await context.Results.Where(r => r.IdExpedient == expedient.IdExpedient).ToListAsync();

            if(results != null)
            {
                context.Results.RemoveRange(results);
                context.SaveChanges();
            }

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

            foreach (var positionTest in position.Tests)
            {
                Test test = await context.Tests.FirstOrDefaultAsync(t => t.IdTest == positionTest.IdTest);

                testNames.Add(test.NameTest);
            }

            return testNames;
        }


        // ---------------------------------
        private async Task<bool> PasswordExist(string password)
        {
            return await context.Candidates.AnyAsync(e => e.Password == password);
        }
        
        private async void AssignTestsCandidate(int positionId, int candidateId)
        {
            List<Test_Position> tests = await context.Test_Positions.Where(t => t.IdPosition == positionId).ToListAsync();

            foreach (var test in tests)
            {
                await context.Test_Candidates.AddAsync(new Test_Candidate
                {
                    IdTest = test.IdTest,
                    IdCandidate = candidateId,
                    Status = false
                });
            }

            await context.SaveChangesAsync();
        }
    }
}
