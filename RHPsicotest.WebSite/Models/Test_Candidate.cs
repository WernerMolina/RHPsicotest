using Microsoft.AspNetCore.Rewrite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Test_Candidate")]
    public class Test_Candidate
    {
        [Key]
        public int IdTest { get; set; }
        
        [Key]
        public int IdCandidate { get; set; }

        public bool Status { get; set; }

        [ForeignKey(nameof(IdTest))]
        [InverseProperty(nameof(Models.Test.Candidates))]
        public virtual Test Test { get; set; }

        [ForeignKey(nameof(IdCandidate))]
        [InverseProperty(nameof(Models.Candidate.Tests))]
        public virtual Candidate Candidate { get; set; }
    }
}
