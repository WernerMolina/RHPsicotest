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
        public string Description { get; set; }

        [InverseProperty(nameof(Question.Test))]
        public virtual IEnumerable<Question> Questions { get; set; }

        [InverseProperty(nameof(Stall.Test))]
        public virtual IEnumerable<Stall> Stalls { get; set; }

    }
}
