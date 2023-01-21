using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.Utilities
{
    public class Conversion
    {
        public static UserDTO ConvertToUserDTO(User user, List<Role> roles, List<Permission> permissions)
        {
            return  new UserDTO
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                RegistrationDate = user.RegistrationDate,
                Roles = roles,
                Permissions = permissions
            };
        }

        public static EmailUser ConvertToEmailUser(EmailUserVM emailUserVM)
        {
            return new EmailUser
            {
                IdRole = emailUserVM.IdRole,
                IdPuesto = emailUserVM.IdPuesto,
                Email = emailUserVM.Email,
                Password = emailUserVM.Password,
                RegistrationDate = DateTime.Now,
            };
        }
        
        public static EmailUserSendDTO ConvertToEmailUserSendDTO(EmailUserVM emailUserVM)
        {
            return new EmailUserSendDTO
            {
                Email = emailUserVM.Email,
                Password = emailUserVM.Password,
            };
        }
    }
}
