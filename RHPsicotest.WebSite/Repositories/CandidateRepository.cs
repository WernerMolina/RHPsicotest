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
            return await context.Candidates.Include(e => e.Role).Include(e => e.Position).ToListAsync();
        }
        
        public async Task<Candidate> GetCandidate(int id)
        {
            return await context.Candidates.Include(c => c.Role).Include(c => c.Position).FirstOrDefaultAsync(c => c.IdCandidate == id);
        }
        
        public async Task<IEnumerable<Position>> GetAllPositions()
        {
            return await context.Positions.ToListAsync();
        }

        private async Task<bool> PasswordExist(string password)
        {
            return await context.Candidates.AnyAsync(e => e.Password == password);
        }
        
        public async Task<Role> GetRoleName()
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.RoleName == "Candidato");
        }

        // Retorna los datos del candidato que se esta logueando y tambien sus permisos
        public async Task<(Candidate, List<Permission>)> GetCandidateLogin(CandidateLogin candidateLogin)
        {
            Candidate candidate = await context.Candidates.Include(c => c.Role).Include(c => c.Position).FirstOrDefaultAsync(u => u.Username == candidateLogin.Username && u.Password == candidateLogin.Password);

            List<Permission> permissions = new List<Permission>();

            if(candidate != null) permissions = await GetPermissionsByRole(candidate.IdRole);
            
            return (candidate, permissions);
        }

        //public async Task<CandidateDTO> GetCandidateDTO(int id)
        //{
        //    Candidate candidate = await GetCandidate(id);

        //    List<Permission> permissionList = new List<Permission>();
        //    List<Permission_Role> permission_roles = new List<Permission_Role>();

        //    permission_roles.AddRange(await context.Permission_Roles.Where(pr => pr.IdRole == candidate.IdRole).ToListAsync());

        //    foreach (Permission_Role permission in permission_roles)
        //    {
        //        permissionList.Add(await context.Permissions.FindAsync(permission.IdPermission));
        //    }

        //    CandidateDTO candidateDTO = Conversion.ConvertToCandidateDTO(candidate, permissionList);

        //    return candidateDTO;
        //}

        // Retorna todos los permisos que tengan el id del rol indicado
        
        public async Task<List<Permission>> GetPermissionsByRole(int roleId)
        {
            List<Permission> permissions = new List<Permission>();
            List<Permission_Role> permissionsRole = new List<Permission_Role>();

            permissionsRole.AddRange(await context.Permission_Roles.Where(pr => pr.IdRole == roleId).ToListAsync());

            foreach (Permission_Role permission in permissionsRole)
            {
                permissions.Add(await context.Permissions.FindAsync(permission.IdPermission));
            }

            return permissions;
        }
    }
}
