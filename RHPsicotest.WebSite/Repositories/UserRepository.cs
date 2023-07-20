using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels.User;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public async Task<bool> AddUser(UserVM userVM)
        {
            bool result;

            userVM.Password = Helper.EncryptMD5(userVM.Password);

            User user = Conversion.ConvertToUser(userVM);

            await context.Users.AddAsync(user);
            result = await context.SaveChangesAsync() > 0;

            if (result) AddRolesToUser(user.IdUser, userVM.RolesId);

            return result;
        }

        public async Task<bool> UpdateUser(UserUpdateVM userUpdateVM)
        {
            bool result = false;

            User user = await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.IdUser == userUpdateVM.IdUser);

            if (user != null)
            {
                if (userUpdateVM.Password != null) user.Password = Helper.EncryptMD5(userUpdateVM.Password);

                user = Conversion.ConvertToUser(user, userUpdateVM);

                context.Users.Update(user);
                result = await context.SaveChangesAsync() > 0;

                if (result) AddRolesToUser(user.IdUser, userUpdateVM.RolesId, true);
            }

            return result;
        }

        public async Task<bool> DeleteUser(int userId)
        {
            bool result = false;

            User user = await context.Users.FirstOrDefaultAsync(u => u.IdUser == userId);

            if (user != null)
            {
                context.Users.Remove(user);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await context.Users.Include("Roles.Role").ToListAsync();
        }

        public async Task<UserUpdateVM> GetUserUpdate(int userId)
        {
            User user = await context.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.IdUser == userId);

            List<int> roles = new List<int>();

            if (user != null)
            {
                foreach (Role_User roleId in user.Roles)
                {
                    Role role = await context.Roles.FirstOrDefaultAsync(p => p.IdRole == roleId.IdRole);

                    roles.Add(role.IdRole);
                }
            }

            UserUpdateVM userUpdateVM = Conversion.ConvertToUserUpdateVM(user, roles);

            return userUpdateVM;
        }

        public async Task<List<Role>> GetAllRoles()
        {
            return await context.Roles.ToListAsync();
        }

        public async Task<bool> UserExists(string email, int id = 0)
        {
            if (id > 0)
            {
                User user = await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.EmailNormalized == email.ToUpper());

                if (user != null)
                {
                    return !(user.IdUser == id && user.EmailNormalized == email.ToUpper());
                }

                return false;
            }

            return await context.Users.AnyAsync(r => r.EmailNormalized == email.ToLower()); ;
        }

        private void AddRolesToUser(int userId, List<int> roles, bool delete = false)
        {
            if (delete)
            {
                List<Role_User> rolesUser = context.Role_Users.Where(ru => ru.IdUser == userId).ToList();

                if (rolesUser != null)
                {
                    context.Role_Users.RemoveRange(rolesUser);
                    context.SaveChanges();
                }
            }

            if (roles != null)
            {
                foreach (int id in roles)
                {
                    context.Role_Users.Add(new Role_User
                    {
                        IdRole = id,
                        IdUser = userId
                    });
                }

                context.SaveChanges();
            }
        }

    }
}
