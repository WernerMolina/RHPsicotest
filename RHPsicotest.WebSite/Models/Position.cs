using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        public int IdPosition { get; set; }

        public int IdTest { get; set; }

        [Display(Name = "Puesto")]
        public string PositionName { get; set; }

        [Display(Name = "Puesto Superior")]
        public string PositionHigher { get; set; }

        [Display(Name = "Departamento")]
        public string Department { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [ForeignKey(nameof(IdTest))]
        [InverseProperty(nameof(Models.Test.Positions))]
        public virtual Test Test { get; set; }

        [InverseProperty(nameof(Candidate.Position))]
        public IEnumerable<Candidate> Candidates { get; set; }
    }
}
