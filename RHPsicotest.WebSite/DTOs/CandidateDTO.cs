using System;
using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.DTOs
{
    public class CandidateDTO
    {
        public int IdCandidate { get; set; }

        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Rol Asignado")]
        public string Role { get; set; }
        
        [Display(Name = "Puesto Asignado")]
        public string Position { get; set; }

        [Display(Name = "Fecha de Registro")]
        public string RegistrationDate { get; set; }

        [Display(Name = "Permisos")]
        public List<string> Permissions { get; set; }

    }
}
