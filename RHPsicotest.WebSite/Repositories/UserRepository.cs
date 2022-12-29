using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly RHPsicotestDbContext context;

        public UserRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        //public async Task<IEnumerable<User>> GetUsers()
        //{
        //    return await context.Users.ToListAsync();
        //}

        public async Task<User> GetUserLogin(UserLogin userLogin)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == userLogin.Email && u.Password == userLogin.Password);
        }
    }
}
