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
            return await context.EmailUsers.Include(e => e.Role).Include(e => e.Stall).ToArrayAsync();
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
    }
}
