using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class UserRepository : IUserRepository
    {

        private readonly RHPsicotestDbContext context;

        public UserRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public async Task<User> AddUser(User user, List<int> roles)
        {
            bool userExists = await UserExists(user);

            if (!userExists)
            {
                user.Password = Encryption.EncryptMD5(user.Password);

                var result = await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                AddRole_User(user.IdUser, roles);

                return result.Entity;
            }

            return null;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var result = false;
            User user = await GetUser(id);

            if (user != null)
            {
                context.Users.Remove(user);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            var users = await context.Users.Include(u => u.Role_Users).ToListAsync();
            var roles = await context.Roles.ToListAsync();

            List<UserDTO> userDTOs = new List<UserDTO>();

            foreach (var user in users)
            {
                List<Role> _roles = new List<Role>();

                foreach (var role in user.Role_Users)
                {
                    _roles.Add(context.Roles.Find(role.IdRole));
                }

                var userDTO = ConversionDTO.ConvertToDTO(user, _roles);

                userDTOs.Add(userDTO);
            }

            return userDTOs;
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await context.Roles.ToListAsync();
        }

        public async Task<UserDTO> GetUserWithRoles(int id)
        {
            List<Role> roles = new List<Role>();
            var user = await context.Users.Include(u => u.Role_Users.Where(u => u.IdUser == id)).FirstOrDefaultAsync(u => u.IdUser == id);

            foreach (var role in user.Role_Users)
            {
                roles.Add(context.Roles.Find(role.IdRole));
            }

            var userDTO = ConversionDTO.ConvertToDTO(user, roles);

            return userDTO;
        }
        
        public async Task<User> GetUser(int id)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.IdUser == id);
        }

        public async Task<User> GetUserLogin(Login userLogin)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == userLogin.Email && u.Password == userLogin.Password);
        }

        public async Task<bool> UpdateUser(UserDTO userDTO, List<int> rolesId)
        {
            var _user = await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == userDTO.Email);
            var user = await GetUser(userDTO.IdUser);

            var result = false;

            if(_user == null || _user.IdUser == userDTO.IdUser)
            {
                user.Name = userDTO.Name;
                user.Email = userDTO.Email;

                context.Users.Update(user);
                result = await context.SaveChangesAsync() > 0;

                AddRole_User(user.IdUser, rolesId, true);
            }

            return result;
        }

        private async Task<bool> UserExists(User user)
        {
            return await context.Users.AnyAsync(u => u.Email == user.Email);
        }

        private void AddRole_User(int userId, List<int> rolesId, bool delete = false)
        {
            if (delete)
            {
                var rolesUsers = context.Role_Users.Where(ru => ru.IdUser == userId).ToList();

                context.Role_Users.RemoveRange(rolesUsers);
                context.SaveChanges();
            }

            foreach (var item in rolesId)
            {
                context.Role_Users.Add(new Role_User
                {
                    IdUser = userId,
                    IdRole = item
                });

            }
            
            context.SaveChanges();
        }

        public async Task<MultiSelectList> GetRolesSelected(int userId)
        {
            var user = await GetUserWithRoles(userId);
            var roleUser = user.Roles;
            var roles = await context.Roles.ToListAsync();

            List<int> rolesSelected = new List<int>();

            foreach (var role in roleUser)
            {
                rolesSelected.Add(role.IdRole);
            }

            return new MultiSelectList(roles, "IdRole", "RoleName", rolesSelected);
        }
    }
}
