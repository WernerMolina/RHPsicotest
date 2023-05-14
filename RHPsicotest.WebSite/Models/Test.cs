using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        public int IdTest { get; set; }

        public string NameTest { get; set; }

        public string Time { get; set; }

        public string Link { get; set; }

        [InverseProperty(nameof(Test_Position.Test))]
        public virtual IEnumerable<Test_Position> Positions { get; set; }

        [InverseProperty(nameof(Test_Candidate.Test))]
        public virtual IEnumerable<Test_Candidate> Candidates { get; set; }

        [InverseProperty(nameof(Result.Test))]
        public virtual IEnumerable<Result> Results { get; set; }

    }
}
