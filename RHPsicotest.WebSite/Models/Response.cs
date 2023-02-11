using Microsoft.AspNetCore.Rewrite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Response")]
    public class Response
    {
        [Key]
        public int IdFactor { get; set; }

        [Key]
        public int IdQuestion { get; set; }

        public string Correct { get; set; }

        public string Incorrect { get; set; }

        [ForeignKey(nameof(IdFactor))]
        [InverseProperty(nameof(Models.Factor.Questions))]
        public virtual Factor Factor { get; set; }

        [ForeignKey(nameof(IdQuestion))]
        [InverseProperty(nameof(Models.Question.Factors))]
        public virtual Question Question { get; set; }
    }
}
