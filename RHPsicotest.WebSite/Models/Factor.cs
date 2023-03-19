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

        public string FactorName { get; set; }

        public string DescriptionFactor { get; set; }

        [InverseProperty(nameof(Result.Factor))]
        public virtual IEnumerable<Result> Results { get; set; }
    }
}
