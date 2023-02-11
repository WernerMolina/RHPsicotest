using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int IdQuestion { get; set; }
        public int IdTest { get; set; }
        public byte QuestionNumber { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }

        [ForeignKey(nameof(IdTest))]
        [InverseProperty(nameof(Models.Test.Questions))]
        public virtual Test Test { get; set; }


        [InverseProperty(nameof(Response.Question))]
        public virtual IEnumerable<Response> Factors { get; set; }

    }
}
