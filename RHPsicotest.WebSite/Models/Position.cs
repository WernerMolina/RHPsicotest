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

        public string PositionName { get; set; }

        public string PositionHigher { get; set; }

        public string Department { get; set; }

        public string CreationDate { get; set; }

        [ForeignKey(nameof(IdTest))]
        [InverseProperty(nameof(Models.Test.Positions))]
        public virtual Test Test { get; set; }

        [InverseProperty(nameof(Candidate.Position))]
        public IEnumerable<Candidate> Candidates { get; set; }
    }
}
