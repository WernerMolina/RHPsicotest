using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
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

        public async Task<(ClaimsIdentity, bool, bool)> GetAuthentication(Login userLogin)
        {
            if (await EmailExists(userLogin.Email, true))
                return await GetCandidateLogin(userLogin);

            if (await EmailExists(userLogin.Email, false))
                return await GetUserLogin(userLogin);

            throw new Exception("El correo no esta registrado");
        }

        private async Task<(ClaimsIdentity, bool, bool)> GetCandidateLogin(Login login)
        {
            Candidate candidate = await context.Candidates
                .Include(c => c.Expedient)
                .Include(c => c.Role)
                .Include(c => c.Position)
                .FirstOrDefaultAsync(u => u.EmailNormalized == login.Email.Trim().ToUpper());

            if (candidate.Password != login.Password.Trim())
                throw new Exception("La contraseña es incorrecta");

            List<string> permissions = await GetCandidatePermissions(candidate.IdRole);

            CandidateLoginDTO candidateLoginDTO = Conversion.ConvertToCandidateLoginDTO(candidate, permissions);

            return (Helper.CandidateAuthenticate(candidateLoginDTO), true, candidateLoginDTO.HasExpediente);
        }

        private async Task<(ClaimsIdentity, bool, bool)> GetUserLogin(Login login)
        {
            User user = await context.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.Email == login.Email);

            if (user.Password != Helper.EncryptMD5(login.Password.Trim()))
                throw new Exception("La contraseña es incorrecta");

            List<string> roles = new List<string>();
            foreach (Role_User roleUser in user.Roles)
            {
                Role role = await context.Roles.FirstOrDefaultAsync(r => r.IdRole == roleUser.IdRole);

                roles.Add(role.RoleName);
            }

            List<string> permissions = await GetUserPermissions(user);

            UserLoginDTO userLoginDTO = Conversion.ConvertToUserLoginDTO(user, roles, permissions);

            return (Helper.UserAuthenticate(userLoginDTO), false, false);
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

        private async Task<bool> EmailExists(string email, bool isCandidate)
        {
            if (isCandidate)
            {
                return await context.Candidates.AnyAsync(c => c.EmailNormalized == email.Trim().ToUpper());
            }

            return await context.Users.AnyAsync(c => c.EmailNormalized == email.Trim().ToUpper());
        }

    }
}
