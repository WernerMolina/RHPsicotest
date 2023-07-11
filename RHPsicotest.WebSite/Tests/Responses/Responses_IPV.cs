using System.Collections.Generic;

namespace RHPsicotest.WebSite.Tests.Responses
{
    public class Responses_IPV
    {
        public byte IdFactor { get; set; }
        public byte QuestionNumber { get; set; }
        public char Correct { get; set; }

        public static List<Responses_IPV> GetResponses()
        {
            return new List<Responses_IPV>
            {
                // Factor I
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 1,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 2,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 19,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 20,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 37,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 38,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 55,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 56,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 73,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 74,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 1,
                    QuestionNumber = 75,
                    Correct = 'C',
                },

                // FActor II
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 3,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 4,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 21,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 22,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 39,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 40,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 57,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 58,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 59,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 76,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 2,
                    QuestionNumber = 77,
                    Correct = 'B',
                },

                // Factor III
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 5,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 6,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 7,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 23,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 24,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 25,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 41,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 42,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 43,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 60,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 3,
                    QuestionNumber = 78,
                    Correct = 'B',
                },

                // Factor IV
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 8,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 26,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 44,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 61,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 62,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 79,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 80,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 4,
                    QuestionNumber = 81,
                    Correct = 'C',
                },

                // Factor V
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 9,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 10,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 11,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 27,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 28,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 29,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 45,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 46,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 63,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 64,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 5,
                    QuestionNumber = 82,
                    Correct = 'C',
                },

                // Factor VI
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 12,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 13,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 30,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 31,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 47,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 48,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 49,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 65,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 66,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 83,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 6,
                    QuestionNumber = 84,
                    Correct = 'A',
                },

                // Factor VII
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 14,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 32,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 50,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 67,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 68,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 85,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 86,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 7,
                    QuestionNumber = 87,
                    Correct = 'A',
                },

                // Factor VIII
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 15,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 33,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 34,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 51,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 52,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 69,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 70,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 8,
                    QuestionNumber = 71,
                    Correct = 'B',
                },

                // Factor IX
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 16,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 17,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 18,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 35,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 36,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 53,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 54,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 9,
                    QuestionNumber = 72,
                    Correct = 'A',
                },

                // Factor DGV
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 1,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 2,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 3,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 4,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 5,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 6,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 7,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 8,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 8,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 9,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 10,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 11,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 12,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 13,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 14,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 15,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 16,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 17,
                    Correct = 'B',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 18,
                    Correct = 'C',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 27,
                    Correct = 'A',
                },
                new Responses_IPV
                {
                    IdFactor = 10,
                    QuestionNumber = 35,
                    Correct = 'A',
                },

            };
        }
    }
    
}