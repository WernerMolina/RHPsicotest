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

        // Crud 
        public Task<User> AddUser(EmailUserVM user)
        {
            throw new System.NotImplementedException();
        }
        
        public async Task<User> AddUser(User user, List<int> rolesId)
        {
            bool userExists = await UserExists(user);

            if (!userExists)
            {
                user.Password = Helper.EncryptMD5(user.Password);

                var result = await context.Users.AddAsync(user);
                await context.SaveChangesAsync();

                AddRole_User(user.IdUser, rolesId);

                return result.Entity;
            }

            return null;
        }
        
        public async Task<bool> UpdateUser(UserDTO userDTO, List<int> rolesId)
        {
            User _user = await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == userDTO.Email);
            User user = await GetUser(userDTO.IdUser);

            bool result = false;

            if (_user == null || _user.IdUser == userDTO.IdUser)
            {
                user.Name = userDTO.Name;
                user.Email = userDTO.Email;

                context.Users.Update(user);
                result = await context.SaveChangesAsync() > 0;

                AddRole_User(user.IdUser, rolesId, true);
            }

            return result;
        }

        public async Task<bool> DeleteUser(int id)
        {
            bool result = false;
            User user = await GetUser(id);

            if (user != null)
            {
                context.Users.Remove(user);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }

        // Get User
        public async Task<UserDTO> GetUserDTO(int id)
        {
            User user = await GetUserWithRoles(id);

            List<Role> roleList = new List<Role>();
            List<Permission> permissionList = new List<Permission>();
            List<Permission_Role> permission_roles = new List<Permission_Role>();

            foreach (var item in user.Roles)
            {
                roleList.Add(await GetRole(item.IdRole));
            }

            foreach (var item in roleList)
            {
                permission_roles.AddRange(await context.Permission_Roles.Where(pr => pr.IdRole == item.IdRole).ToListAsync());
            }

            foreach (var permission in permission_roles)
            {
                permissionList.Add(await context.Permissions.FindAsync(permission.IdPermission));
            }

            UserDTO userDTO = Conversion.ConvertToUserDTO(user, roleList, permissionList);

            return userDTO;
        }
        
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await context.Users.Include("Roles.Role").ToListAsync();

            //List<UserDTO> userDTOs = new List<UserDTO>();

            //foreach (var user in users)
            //{
            //    List<Role> _roles = new List<Role>();

            //    foreach (var role in user.Roles)
            //    {
            //        _roles.Add(context.Roles.Find(role.IdRole));
            //    }

            //    var userDTO = ConversionDTO.ConvertToDTO(user, _roles);

            //    userDTOs.Add(userDTO);
            //}
        }
        
        public async Task<User> GetUserWithRoles(int id)
        {
            return await context.Users.Include("Roles.Role").FirstOrDefaultAsync(u => u.IdUser == id);
        }
        
        public async Task<UserDTO> GetUserLogin(Login userLogin)
        {
            User user = await context.Users.FirstOrDefaultAsync(u => u.Email == userLogin.Email && u.Password == userLogin.Password);

            UserDTO userDTO = null;

            if (user != null)
            {
                userDTO = await GetUserDTO(user.IdUser);
            }

            return userDTO;
        }

        // Get Role
        public async Task<MultiSelectList> GetAllRoles()
        {
            List<Role> roles = await context.Roles.ToListAsync();

            return new MultiSelectList(roles, "IdRole", "RoleName");
        }

        public async Task<MultiSelectList> GetRolesSelected(int userId)
        {
            UserDTO user = await GetUserDTO(userId);
            IEnumerable<Role> roleUser = user.Roles;
            var roles = await context.Roles.ToListAsync();

            List<int> selectedRoles = new List<int>();

            foreach (Role role in roleUser)
            {
                selectedRoles.Add(role.IdRole);
            }

            return new MultiSelectList(roles, "IdRole", "RoleName", selectedRoles);
        }

        // Complementary Methods
        private async Task<User> GetUser(int id)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.IdUser == id);
        }

        private async Task<Role> GetRole(int id)
        {
            return await context.Roles.FirstOrDefaultAsync(u => u.IdRole == id);
        }

        private async Task<bool> UserExists(User user)
        {
            return await context.Users.AnyAsync(u => u.Email == user.Email);
        }

        private void AddRole_User(int userId, List<int> roles, bool delete = false)
        {
            if (delete)
            {
                List<Role_User> rolesUser = context.Role_Users.Where(ru => ru.IdUser == userId).ToList();

                context.Role_Users.RemoveRange(rolesUser);
                context.SaveChanges();
            }

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
