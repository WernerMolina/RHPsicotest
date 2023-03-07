using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using RHPsicotest.WebSite.ViewModels.User;
using System;
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


        public async Task<bool> AddUser(UserVM userVM, List<int> rolesId)
        {
            bool result = false;

            bool userExists = await UserExists(userVM);

            if (!userExists)
            {
                userVM.Password = Helper.EncryptMD5(userVM.Password);

                User user = Conversion.ConvertToUser(userVM);

                await context.Users.AddAsync(user);
                result = await context.SaveChangesAsync() > 0;

                RolesAsign(user.IdUser, rolesId);
            }

            return result;
        }

        public async Task<bool> UpdateUser(UserUpdateVM userUpdateVM, List<int> rolesId)
        {
            bool result = false;

            User userExist = await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == userUpdateVM.Email);

            if (userExist == null || userExist.IdUser == userUpdateVM.IdUser)
            {
                User user = await context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.IdUser == userUpdateVM.IdUser);

                if (userUpdateVM.Password != null) user.Password = Helper.EncryptMD5(userUpdateVM.Password);

                user = Conversion.ConvertToUser(user, userUpdateVM);

                context.Users.Update(user);
                result = await context.SaveChangesAsync() > 0;

                if (result) RolesAsign(user.IdUser, rolesId, true);
            }

            return result;
        }

        public async Task<bool> DeleteUser(int userId)
        {
            bool result = false;
            User user = await context.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.IdUser == userId);

            if (user != null)
            {
                context.Users.Remove(user);
                result = await context.SaveChangesAsync() > 0;
            }

            return result;
        }


        // Retorna todos los usuarios en version DTO
        // UserDTO = Datos del usuario + los roles + los permisos
        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            List<User> users = await context.Users.Include(u => u.Roles).ToListAsync();

            List<UserDTO> userDTOs = new List<UserDTO>();

            foreach (User user in users)
            {
                userDTOs.Add(await GetUserDTO(user, false));
            }

            return userDTOs;
        }


        // Cuando el admin da clic en actualizar un usuario
        // Retorna los datos del usuario y todos los roles.
        // También van seleccionados los roles que tiene asignados el usuario
        public async Task<(UserUpdateVM, MultiSelectList)> GetUserAndRolesSelected(int userId)
        {
            User user = await context.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.IdUser == userId);

            UserUpdateVM userUpdateVM = Conversion.ConvertToUserUpdateVM(user);

            MultiSelectList rolesList = await GetRolesSelected(user);

            return (userUpdateVM, rolesList);
        }


        // Retorna todos los roles 
        public async Task<MultiSelectList> GetAllRoles()
        {
            List<Role> roles = await context.Roles.ToListAsync();

            return new MultiSelectList(roles, "IdRole", "RoleName");
        }




        public async Task<MultiSelectList> GetRolesSelected(List<int> rolesId)
        {
            List<int> selectedRoles = new List<int>();
            List<Role> roles = await context.Roles.ToListAsync();

            foreach (int role in rolesId)
            {
                selectedRoles.Add(role);
            }

            return new MultiSelectList(roles, "IdRole", "RoleName", selectedRoles);
        }

        // ------------------------ Métodos Complementarios-----------------------------

        // Convierte un usuario en DTO para mostrar los datos en una vista
        // UserDTO = Datos del usuario + los roles + los permisos
        private async Task<UserDTO> GetUserDTO(User user, bool withPermissions)
        {
            List<string> roles = new List<string>();
            List<string> permissions = new List<string>();

            List<Role> userRoles = new List<Role>();

            foreach (var role in user.Roles)
            {
                userRoles.Add(await context.Roles.Include(r => r.Permissions).FirstOrDefaultAsync(r => r.IdRole == role.IdRole));
            }

            foreach (Role role in userRoles)
            {
                roles.Add(role.RoleName);

                if (withPermissions)
                {
                    foreach (var permission in role.Permissions)
                    {
                        Permission permiso = await context.Permissions.FirstOrDefaultAsync(p => p.IdPermission == permission.IdPermission);

                        permissions.Add(permiso.PermissionName);
                    }
                }
            }

            UserDTO userDTO = Conversion.ConvertToUserDTO(user, roles, permissions);

            return userDTO;
        }


        // Método que se utiliza cuando se va actualizar un usuario
        // Retorna todos los roles y también van seleccionados los roles del usuario
        private async Task<MultiSelectList> GetRolesSelected(User user)
        {
            List<int> selectedRoles = new List<int>();
            List<Role> roles = await context.Roles.ToListAsync();

            foreach (var role in user.Roles)
            {
                selectedRoles.Add(role.IdRole);
            }

            return new MultiSelectList(roles, "IdRole", "RoleName", selectedRoles);
        }

        private async Task<bool> UserExists(UserVM user)
        {
            return await context.Users.AnyAsync(u => u.Email == user.Email);
        }

        // Actualiza los roles del usuario
        private void RolesAsign(int userId, List<int> roles, bool delete = false)
        {
            // Aquí se eliminan los roles actuales del usuario
            if (delete)
            {
                List<Role_User> rolesUser = context.Role_Users.Where(ru => ru.IdUser == userId).ToList();

                if (rolesUser != null)
                {
                    context.Role_Users.RemoveRange(rolesUser);
                    context.SaveChanges();
                }
            }

            // Aquí se guardan los nuevos roles asignados
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
