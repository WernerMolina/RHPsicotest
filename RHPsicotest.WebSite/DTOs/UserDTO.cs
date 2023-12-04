using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.DTOs
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Fecha de Registro")]
        public string RegistrationDate { get; set; }

        [Display(Name = "Roles")]
        public List<string> Roles { get; set; }
        
    }
}
