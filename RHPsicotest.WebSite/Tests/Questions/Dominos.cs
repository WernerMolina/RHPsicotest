using System.Collections.Generic;

namespace RHPsicotest.WebSite.Tests.Questions
{
    public class Dominos
    {
        public int QuestionNumber { get; set; }
        public string ImagePath { get; set; }

        public static List<Dominos> Questions()
        {
            return new List<Dominos>
            {
                new Dominos
                {
                    QuestionNumber = 1,
                    ImagePath = @"~/img/Dominos/Domino1.jpg"
                },
                new Dominos
                {
                    QuestionNumber = 2,
                    ImagePath = @"~/img/Dominos/Domino2.jpg"
                },
            };
        }
    }
}
