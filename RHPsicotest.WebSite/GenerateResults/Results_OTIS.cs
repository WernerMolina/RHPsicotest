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

            foreach (var response in responsesOTIS)
            {
                if (candidateResponses[counter] == response.Correct) scoreTotal++;

                counter++;
            }

            return scoreTotal;
        }

        public static byte GetCIByScore(byte score)
        {
            byte CI = 0;

            if (score == 75) CI = 127;
            if (score == 74) CI = 126;
            if (score == 73) CI = 125;
            if (score == 72) CI = 124;
            if (score >= 70) CI = 122;
            if (score >= 68) CI = 120;
            if (score >= 66) CI = 118;
            if (score == 65) CI = 116;
            if (score >= 63) CI = 114;
            if (score >= 61) CI = 112;
            if (score >= 59) CI = 110;
            if (score >= 57) CI = 108;
            if (score >= 55) CI = 106;
            if (score >= 53) CI = 104;
            if (score >= 51) CI = 102;
            if (score >= 49) CI = 100;
            if (score >= 47) CI = 98;
            if (score >= 45) CI = 96;
            if (score >= 43) CI = 94;
            if (score >= 41) CI = 92;
            if (score >= 39) CI = 90;
            if (score >= 37) CI = 88;
            if (score >= 35) CI = 86;
            if (score >= 33) CI = 84;
            if (score == 32) CI = 82;
            if (score >= 30) CI = 80;
            if (score >= 28) CI = 78;
            if (score >= 26) CI = 76;
            if (score >= 24) CI = 74;
            if (score >= 22) CI = 72;
            if (score >= 20) CI = 70;
            if (score >= 18) CI = 68;
            if (score == 17) CI = 66;
            if (score <= 16) CI = 65;

            return CI;
        }

        public static string GetDescriptionByCI(byte CI)
        {
            if (CI > 0) return "Rango Alto: el sujeto posee una inteligencia general muy buena, indicando una alta capacidad para utilizar su razonamiento a la hora de comprender y resolver los problemas. Posee una muy buena facultad de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";
            if (CI > 0) return "Rango Intermedio: el sujeto posee una inteligencia general promedio, indicando una capacidad promedio para utilizar su razonamiento a la hora de comprender y resolver los problemas. Posee una facultad promedio de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";
            if (CI > 0) return "Rango Bajo: el sujeto posee una inteligencia general bastante limitada. La persona presenta dificultades a la hora de comprender y resolver los problemas. Posee una limitada facultad de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";

            return string.Empty;
        }
    }
}
