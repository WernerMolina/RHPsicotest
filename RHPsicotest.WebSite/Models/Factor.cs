using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Factor")]
    public class Factor
    {
        [Key]
        public int IdFactor { get; set; }
        public string NameFactor { get; set; }

        [InverseProperty(nameof(Factor_Question.Factor))]
        public virtual IEnumerable<Factor_Question> Questions { get; set; }

    }
}
