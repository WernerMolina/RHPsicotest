using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System;

namespace RHPsicotest.WebSite.DTOs
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime RegistrationDate { get; set; }

        public IEnumerable<Role> Roles { get; set; }

    }
}
