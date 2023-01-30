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
                Username = "MGLR",
                Email = emailUserVM.Email,
                Password = emailUserVM.Password,
                RegistrationDate = DateTime.Now,
            };
        }
        
        public static Expedient ConvertToExpedient(ExpedientVM expedientVM, byte[] filePDFInBytes)
        {
            return new Expedient
            {
                DUI = expedientVM.DUI,
                Names = expedientVM.Names,
                Lastnames = expedientVM.Lastnames,
                Email = expedientVM.Email,
                MovilePhoneNumber = expedientVM.MovilePhoneNumber,
                LandlineNumber = expedientVM.LandlineNumber,
                DateOfBirth = expedientVM.DateOfBirth,
                Gender = expedientVM.Gender,
                CivilStatus = expedientVM.CivilStatus,
                Stall = expedientVM.Stall,
                AcademicTraining = expedientVM.AcademicTraining,
                Certificate = expedientVM.Certificate,
                CurriculumVitae = filePDFInBytes,
                Country = expedientVM.Country,
                Department = expedientVM.Department,
                Municipality = expedientVM.Municipality,
                Direction = expedientVM.Direction
            };
        }
        
        public static EmailUserDTO ConvertToEmailUserDTO(EmailUser emailUser, List<Permission> permissions)
        {
            return new EmailUserDTO
            {
                IdUser = emailUser.IdUser,
                Username = "MGLR",
                Email = emailUser.Email,
                Password = emailUser.Password,
                RegistrationDate = DateTime.Now,
                Role = emailUser.Role,
                Permissions = permissions
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
