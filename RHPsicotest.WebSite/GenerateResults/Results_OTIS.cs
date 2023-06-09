using RHPsicotest.WebSite.Tests.Responses;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.GenerateResults
{
    public class Results_OTIS
    {
        public static byte GetScoreTotal(char[] candidateResponses)
        {
            byte scoreTotal = 0;

            List<Responses_OTIS> responsesOTIS = Responses_OTIS.GetResponses();

            byte counter = 0;

            foreach (Responses_OTIS response in responsesOTIS)
            {
                if (candidateResponses[counter] == response.Correct) scoreTotal++;

                counter++;
            }

            return scoreTotal;
        }

        public static byte GetIQByScore(byte score)
        {
            if (score == 75) return 127;
            if (score == 74) return 126;
            if (score == 73) return 125;
            if (score == 72) return 124;
            if (score >= 70) return 122;
            if (score >= 68) return 120;
            if (score >= 66) return 118;
            if (score == 65) return 116;
            if (score >= 63) return 114;
            if (score >= 61) return 112;
            if (score >= 59) return 110;
            if (score >= 57) return 108;
            if (score >= 55) return 106;
            if (score >= 53) return 104;
            if (score >= 51) return 102;
            if (score >= 49) return 100;
            if (score >= 47) return 98;
            if (score >= 45) return 96;
            if (score >= 43) return 94;
            if (score >= 41) return 92;
            if (score >= 39) return 90;
            if (score >= 37) return 88;
            if (score >= 35) return 86;
            if (score >= 33) return 84;
            if (score == 32) return 82;
            if (score >= 30) return 80;
            if (score >= 28) return 78;
            if (score >= 26) return 76;
            if (score >= 24) return 74;
            if (score >= 22) return 72;
            if (score >= 20) return 70;
            if (score >= 18) return 68;
            if (score == 17) return 66;
            if (score >= 0) return 65;

            return 0;
        }

        public static string GetDescriptionByIQ(byte IQ)
        {
            if (IQ >= 102) return "Rango Alto: El sujeto posee una inteligencia general muy buena, indicando una alta capacidad para utilizar su razonamiento a la hora de comprender y resolver los problemas. Posee una muy buena facultad de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";
            if (IQ == 100) return "Rango Intermedio: El sujeto posee una inteligencia general promedio, indicando una capacidad promedio para utilizar su razonamiento a la hora de comprender y resolver los problemas. Posee una facultad promedio de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";
            if (IQ >= 65) return "Rango Bajo: El sujeto posee una inteligencia general bastante limitada. La persona presenta dificultades a la hora de comprender y resolver los problemas. Posee una limitada facultad de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";

            return string.Empty;
        }
    }
}
