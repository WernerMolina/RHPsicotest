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
    public class EmailUserRepository : IEmailUserRepository
    {
        private readonly RHPsicotestDbContext context;

        public EmailUserRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<EmailUserSendDTO> AddEmailUser(EmailUserVM emailUserVM)
        {
            bool passwordExists = await PasswordExist(emailUserVM.Password);

            if (!passwordExists)
            {
                EmailUser emailUser = Conversion.ConvertToEmailUser(emailUserVM);

                await context.EmailUsers.AddAsync(emailUser);
                await context.SaveChangesAsync();

                EmailUserSendDTO emailUserSend = Conversion.ConvertToEmailUserSendDTO(emailUserVM);

                return emailUserSend;
            }

            return null;
        }

        public async Task<IEnumerable<EmailUser>> GetAllEmailUsers()
        {
            return await context.EmailUsers.Include(e => e.Stall).ToArrayAsync();
        }
        
        public async Task<EmailUser> GetEmailUser(int id)
        {
            return await context.EmailUsers.Include(u => u.Role).FirstOrDefaultAsync(c => c.IdUser == id);
        }
        
        public async Task<IEnumerable<Stall>> GetAllStalls()
        {
            return await context.Stalls.ToArrayAsync();
        }

        private async Task<bool> PasswordExist(string password)
        {
            return await context.EmailUsers.AnyAsync(e => e.Password == password);
        }
        
        public async Task<Role> GetRoleName()
        {
            return await context.Roles.FirstOrDefaultAsync(r => r.RoleName == "Candidato");
        }

        public async Task<EmailUserDTO> GetCandidateLogin(CandidateLogin candidateLogin)
        {
            EmailUser emailUser = await context.EmailUsers.FirstOrDefaultAsync(u => u.Username == candidateLogin.Username && u.Password == candidateLogin.Password);

            EmailUserDTO emailUserDTO = null;

            if(emailUser != null)
            {
                emailUserDTO = await GetEmailUserDTO(emailUser.IdUser);
            }

            return emailUserDTO;
        }

        public async Task<EmailUserDTO> GetEmailUserDTO(int id)
        {
            EmailUser emailUser = await GetEmailUser(id);

            List<Permission> permissionList = new List<Permission>();
            List<Permission_Role> permission_roles = new List<Permission_Role>();

            permission_roles.AddRange(await context.Permission_Roles.Where(pr => pr.IdRole == emailUser.IdRole).ToListAsync());

            foreach (var permission in permission_roles)
            {
                permissionList.Add(await context.Permissions.FindAsync(permission.IdPermission));
            }

            EmailUserDTO emailUserDTO = Conversion.ConvertToEmailUserDTO(emailUser, permissionList);

            return emailUserDTO;
        }
    }
}
