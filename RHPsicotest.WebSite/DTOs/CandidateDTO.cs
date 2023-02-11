using System;
using RHPsicotest.WebSite.Models;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.DTOs
{
    public class CandidateDTO
    {
        public int IdUser { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public DateTime RegistrationDate { get; set; }

        public IEnumerable<Permission> Permissions { get; set; }

    }
}
