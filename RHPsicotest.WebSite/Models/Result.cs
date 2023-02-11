using Microsoft.AspNetCore.Rewrite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Result")]
    public class Result
    {
        [Key]
        public int IdExpedient { get; set; }

        [Key]
        public int IdFactor { get; set; }

        public byte Score { get; set; }

        public byte Percentile { get; set; }

        [ForeignKey(nameof(IdExpedient))]
        [InverseProperty(nameof(Models.Expedient.Results))]
        public virtual Expedient Expedient{ get; set; }

        [ForeignKey(nameof(IdFactor))]
        [InverseProperty(nameof(Models.Factor.Results))]
        public virtual Factor Factor { get; set; }
    }
}
