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

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Roles")]
        public IEnumerable<Role> Roles { get; set; }
        
        [Display(Name = "Permisos")]
        public IEnumerable<Permission> Permissions { get; set; }

    }
}
