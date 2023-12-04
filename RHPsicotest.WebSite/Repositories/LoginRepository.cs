using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly RHPsicotestDbContext context;

        public LoginRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<CandidateLoginDTO> GetCandidateLogin(Login login)
        {
            Candidate candidate = await context.Candidates
                .Include(c => c.Expedient)
                .Include(c => c.Role)
                .Include(c => c.Position)
                .FirstOrDefaultAsync(u => u.EmailNormalized == login.Email.Trim().ToUpper());

            List<string> permissions = new List<string>();

            CandidateLoginDTO candidateLoginDTO = null;

            bool isPassCorrect = candidate.Password == login.Password.Trim();

            if (isPassCorrect)
            {
                permissions = await GetCandidatePermissions(candidate.IdRole);

                candidateLoginDTO = Conversion.ConvertToCandidateLoginDTO(candidate, permissions);
            }

            return candidateLoginDTO;
        }

        public async Task<UserLoginDTO> GetUserLogin(Login login)
        {
            User user = await context.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.Email == login.Email);

            List<string> roles = new List<string>();
            List<string> permissions = new List<string>();

            UserLoginDTO userLoginDTO = null;

            bool isPassCorrect = user.Password == Helper.EncryptMD5(login.Password.Trim());

            if (isPassCorrect)
            {
                foreach (Role_User roleUser in user.Roles)
                {
                    Role role = await context.Roles.FirstOrDefaultAsync(r => r.IdRole == roleUser.IdRole);

                    roles.Add(role.RoleName);
                }

                permissions = await GetUserPermissions(user);

                userLoginDTO = Conversion.ConvertToUserLoginDTO(user, roles, permissions);
            }
 
            return userLoginDTO;
        }

        private async Task<List<string>> GetUserPermissions(User user)
        {
            List<Role> roles = new List<Role>();
            List<string> permissions = new List<string>();

            foreach (Role_User role in user.Roles)
            {
                roles.Add(await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.IdRole == role.IdRole));
            }

            foreach (Role role in roles)
            {
                foreach (Permission_Role permissionRole in role.Permissions)
                {
                    Permission permission = await context.Permissions.FirstOrDefaultAsync(p => p.IdPermission == permissionRole.IdPermission);

                    permissions.Add(permission.PermissionNamePolicy);
                }
            }

            return permissions;
        }

        private async Task<List<string>> GetCandidatePermissions(int roleId)
        {
            List<string> permissions = new List<string>();

            Role role = await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.IdRole == roleId);

            foreach (Permission_Role permissionRole in role.Permissions)
            {
                Permission permission = await context.Permissions.FirstOrDefaultAsync(p => p.IdPermission == permissionRole.IdPermission);

                permissions.Add(permission.PermissionNamePolicy);
            }

            return permissions;
        }

        public async Task<bool> EmailExists(string email, bool isCandidate)
        {
            if (isCandidate)
            {
                return await context.Candidates.AnyAsync(c => c.EmailNormalized == email.Trim().ToUpper());
            }

            return await context.Users.AnyAsync(c => c.EmailNormalized == email.Trim().ToUpper());
        }

    }
}
