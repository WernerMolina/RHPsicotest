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
        public int IdTest { get; set; }

        [Display(Name = "Puesto")]
        public string StallName { get; set; }

        [Display(Name = "Puesto Superior")]
        public string StallHigher { get; set; }

        [Display(Name = "Departamento")]
        public string Department { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [ForeignKey(nameof(IdTest))]
        [InverseProperty(nameof(Models.Test.Stalls))]
        public virtual Test Test { get; set; }


        [InverseProperty(nameof(Candidate.Stall))]
        public IEnumerable<Candidate> EmailUsers { get; set; }
    }
}
