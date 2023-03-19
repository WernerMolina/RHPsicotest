using System.Collections.Generic;

namespace RHPsicotest.WebSite.Tests.Responses
{
    public class R_OTIS
    {
        public int QuestionNumber { get; set; }
        public string Correct { get; set; }

        public static List<R_OTIS> GetResponses()
        {
            return new List<R_OTIS>
            {
                new R_OTIS
                {
                    QuestionNumber = 1,
                    Correct = "A"
                },
                new R_OTIS
                {
                    QuestionNumber = 2,
                    Correct = "C"
                },
                new R_OTIS
                {
                    QuestionNumber = 3,
                    Correct = "D"
                },
                new R_OTIS
                {
                    QuestionNumber = 4,
                    Correct = "D"
                },
                new R_OTIS
                {
                    QuestionNumber = 5,
                    Correct = "B"
                },
                new R_OTIS
                {
                    QuestionNumber = 6,
                    Correct = "A"
                },
            };
        }
    }
}
