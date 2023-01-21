using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System;

namespace RHPsicotest.WebSite.Utilities
{
    public class RevertizationDTO
    {
        public static EmailUser RevertDTO(EmailUserVM user)
        {
            return new EmailUser
            {
                IdRole = user.IdRole,
                IdPuesto = user.IdPuesto,
                Email = user.Email,
                Password = user.Password,
                RegistrationDate = DateTime.Now,
            };
        }
    }
}
