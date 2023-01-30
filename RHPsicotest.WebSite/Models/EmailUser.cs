using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace RHPsicotest.WebSite.Models
{
    [Table("EmailUser")]
    public class EmailUser
    {
        [Key]
        public int IdUser { get; set; }

        public int IdRole { get; set; }

        public int IdPuesto { get; set; }

        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Fecha")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        [Display(Name = "Puesto")]
        [ForeignKey(nameof(IdPuesto))]
        [InverseProperty(nameof(Models.Stall.EmailUsers))]
        public virtual Stall Stall { get; set; }

        [Display(Name = "Rol")]
        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(Models.Role.EmailUsers))]
        public virtual Role Role{ get; set; }
    }
}
