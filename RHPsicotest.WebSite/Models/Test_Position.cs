using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Test_Position")]
    public class Test_Position
    {
        [Key]
        public int IdTest { get; set; }

        [Key]
        public int IdPosition { get; set; }

        [ForeignKey(nameof(IdTest))]
        [InverseProperty(nameof(Models.Test.Positions))]
        public virtual Test Test { get; set; }

        [ForeignKey(nameof(IdPosition))]
        [InverseProperty(nameof(Models.Position.Tests))]
        public virtual Position Position { get; set; }
    }
}
