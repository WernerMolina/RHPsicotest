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

        public async Task<IEnumerable<Candidate>> GetAllCandidates()
        {
            return await context.Candidates.Include(e => e.Role).Include(e => e.Stall).ToArrayAsync();
        }
        
        public async Task<Candidate> GetCandidate(int id)
        {
            return await context.Candidates.Include(u => u.Role).FirstOrDefaultAsync(c => c.IdUser == id);
        }
        
        public async Task<IEnumerable<Stall>> GetAllStalls()
        {
            return await context.Stalls.ToArrayAsync();
        }

        private async Task<bool> PasswordExist(string password)
        {
            return await context.Candidates.AnyAsync(e => e.Password == password);
        }
        
        public async Task<Role> GetRoleName()
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.RoleName == "Candidato");
        }

        public async Task<CandidateDTO> GetCandidateLogin(CandidateLogin candidateLogin)
        {
            Candidate candidate = await context.Candidates.FirstOrDefaultAsync(u => u.Username == candidateLogin.Username && u.Password == candidateLogin.Password);

            CandidateDTO candidateDTO = null;

            if(candidate != null)
            {
                candidateDTO = await GetCandidateDTO(candidate.IdUser);
            }

            return candidateDTO;
        }

        public async Task<CandidateDTO> GetCandidateDTO(int id)
        {
            Candidate emailUser = await GetCandidate(id);

            List<Permission> permissionList = new List<Permission>();
            List<Permission_Role> permission_roles = new List<Permission_Role>();

            permission_roles.AddRange(await context.Permission_Roles.Where(pr => pr.IdRole == emailUser.IdRole).ToListAsync());

            foreach (var permission in permission_roles)
            {
                permissionList.Add(await context.Permissions.FindAsync(permission.IdPermission));
            }

            CandidateDTO emailUserDTO = Conversion.ConvertToCandidateDTO(emailUser, permissionList);

            return emailUserDTO;
        }

    }
}
