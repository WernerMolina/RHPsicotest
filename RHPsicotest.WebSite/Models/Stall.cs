using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Stall")]
    public class Stall
    {
        [Key]
        public int IdStall { get; set; }

        [Display(Name = "Puesto")]
        public string StallName { get; set; }

        [Display(Name = "Puesto Superior")]
        public string StallHigher { get; set; }

        [Display(Name = "Departamento")]
        public string Department { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [InverseProperty(nameof(EmailUser.Stall))]
        public IEnumerable<EmailUser> EmailUsers { get; set; }
    }
}
