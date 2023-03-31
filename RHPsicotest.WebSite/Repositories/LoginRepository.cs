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

        
        public async Task<(Candidate, List<string>)> GetCandidateLogin(Login login)
        {
            Candidate candidate = await context.Candidates.Include(c => c.Expedient).Include(c => c.Role).Include(c => c.Position).FirstOrDefaultAsync(u => u.Email == login.Email);

            List<string> permissions = new List<string>();
            
            if (candidate != null)
            {
                bool isPassCorrect = candidate.Password == login.Password;

                if (isPassCorrect)
                {
                    permissions = await GetCandidatePermissions(candidate.IdRole);
                }
                else
                {
                    candidate = null;
                }
            }

            return (candidate, permissions);
        }


        public async Task<(User, List<string>)> GetUserLogin(Login login)
        {
            User user = await context.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.Email == login.Email);

            List<string> permissions = new List<string>();
            
            if(user != null)
            {
                bool isPassCorrect = user.Password == Helper.EncryptMD5(login.Password);

                if (isPassCorrect)
                {
                    permissions = await GetUserPermissions(user);
                }
                else
                {
                    user = null;
                }
            }

            return (user, permissions);
        }


        private async Task<List<string>> GetUserPermissions(User user)
        {
            List<string> permissions = new List<string>();
            List<Role> userRoles = new List<Role>();

            foreach (var role in user.Roles)
            {
                userRoles.Add(await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.IdRole == role.IdRole));
            }

            foreach (Role role in userRoles)
            {
                foreach (var permission in role.Permissions)
                {
                    Permission permiso = await context.Permissions.FirstOrDefaultAsync(p => p.IdPermission == permission.IdPermission);

                    permissions.Add(permiso.PermissionName);
                }
            }

            return permissions;
        }

        private async Task<List<string>> GetCandidatePermissions(int roleId)
        {
            List<string> permissions = new List<string>();

            Role role = await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.IdRole == roleId);

            foreach (var permission in role.Permissions)
            {
                Permission permiso = await context.Permissions.FirstOrDefaultAsync(p => p.IdPermission == permission.IdPermission);

                permissions.Add(permiso.PermissionName);
            }

            return permissions;
        }

    }
}
