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

        public async Task<CandidateSendDTO> AddCandidate(CandidateVM candidateVM)
        {
            bool passwordExists = await PasswordExist(candidateVM.Password);

            if (!passwordExists)
            {
                Candidate candidate = Conversion.ConvertToCandidate(candidateVM);

                await context.Candidates.AddAsync(candidate);
                await context.SaveChangesAsync();

                CandidateSendDTO candidateSendDTO = Conversion.ConvertToCandidateSendDTO(candidateVM);

                return candidateSendDTO;
            }

            return null;
        }

        public async Task<IEnumerable<CandidateDTO>> GetAllCandidates()
        {
            List<Candidate> candidates = await context.Candidates.Include(c => c.Role).Include(c => c.Position).ToListAsync();

            List<CandidateDTO> candidateDTOs = new List<CandidateDTO>();

            foreach (Candidate candidate in candidates)
            {
                candidateDTOs.Add(Conversion.ConvertToCandidateDTO(candidate));
            }

            return candidateDTOs;
        }
                
        public async Task<IEnumerable<Position>> GetAllPositions()
        {
            return await context.Positions.ToListAsync();
        }

        public async Task<Role> GetRoleName()
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.RoleName == "Candidato");
        }

        private async Task<bool> PasswordExist(string password)
        {
            return await context.Candidates.AnyAsync(e => e.Password == password);
        }
    }
}
