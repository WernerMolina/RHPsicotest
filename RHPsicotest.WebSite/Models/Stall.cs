using System;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    public class Stall
    {
        [Key]
        public int IdStall { get; set; }

        [Display(Name = "Nombre")]
        public string StallName { get; set; }

        [Display(Name = "Puesto Superior")]
        public string StallHigher { get; set; }

        [Display(Name = "Departamento")]
        public string Department { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
