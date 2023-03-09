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
        public string DescriptionFactor { get; set; }

        [InverseProperty(nameof(Response.Factor))]
        public virtual IEnumerable<Response> Questions { get; set; }

        [InverseProperty(nameof(Models.Result.Factor))]
        public virtual IEnumerable<Result> Results { get; set; }
    }
}
