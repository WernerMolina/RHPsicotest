
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Contaseña")]
        public string Password { get; set; }

        [Display(Name = "Fehca de Registro")]
        public DateTime RegistrationDate { get; set; } = DateTime.Now.Date;

        [Display(Name = "Roles")]
        [InverseProperty(nameof(Role_User.User))]
        public virtual IEnumerable<Role_User> Roles { get; set; }

    }
}
