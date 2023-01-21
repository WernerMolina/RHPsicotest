using Microsoft.AspNetCore.Mvc.Rendering;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface IEmailUserRepository
    {
        public Task<IEnumerable<EmailUser>> GetAllEmailUsers();

        public Task<IEnumerable<Stall>> GetAllStalls();

        public Task<EmailUserSendDTO> AddEmailUser(EmailUserVM emailUser);

        public Task<Role> GetRoleName();
    }
}
