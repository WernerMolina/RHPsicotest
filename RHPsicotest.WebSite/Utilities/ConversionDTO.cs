using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.Linq;

namespace RHPsicotest.WebSite.Utilities
{
    public class ConversionDTO
    {
        public static UserDTO ConvertToDTO(User user, List<Role> roles)
        {
            return  new UserDTO
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                RegistrationDate = user.RegistrationDate,
                Roles = roles
            };
        }
    }
}
