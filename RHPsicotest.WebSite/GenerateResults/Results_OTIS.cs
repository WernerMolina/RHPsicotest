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
            byte IQ = 0;

            if (score == 75) IQ = 127;
            if (score == 74) IQ = 126;
            if (score == 73) IQ = 125;
            if (score == 72) IQ = 124;
            if (score >= 70) IQ = 122;
            if (score >= 68) IQ = 120;
            if (score >= 66) IQ = 118;
            if (score == 65) IQ = 116;
            if (score >= 63) IQ = 114;
            if (score >= 61) IQ = 112;
            if (score >= 59) IQ = 110;
            if (score >= 57) IQ = 108;
            if (score >= 55) IQ = 106;
            if (score >= 53) IQ = 104;
            if (score >= 51) IQ = 102;
            if (score >= 49) IQ = 100;
            if (score >= 47) IQ = 98;
            if (score >= 45) IQ = 96;
            if (score >= 43) IQ = 94;
            if (score >= 41) IQ = 92;
            if (score >= 39) IQ = 90;
            if (score >= 37) IQ = 88;
            if (score >= 35) IQ = 86;
            if (score >= 33) IQ = 84;
            if (score == 32) IQ = 82;
            if (score >= 30) IQ = 80;
            if (score >= 28) IQ = 78;
            if (score >= 26) IQ = 76;
            if (score >= 24) IQ = 74;
            if (score >= 22) IQ = 72;
            if (score >= 20) IQ = 70;
            if (score >= 18) IQ = 68;
            if (score == 17) IQ = 66;
            if (score <= 16) IQ = 65;

            return IQ;
        }

        public static string GetDescriptionByCI(byte IQ)
        {
            if (IQ >= 102) return "Rango Alto: El sujeto posee una inteligencia general muy buena, indicando una alta capacidad para utilizar su razonamiento a la hora de comprender y resolver los problemas. Posee una muy buena facultad de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";
            if (IQ == 100) return "Rango Intermedio: El sujeto posee una inteligencia general promedio, indicando una capacidad promedio para utilizar su razonamiento a la hora de comprender y resolver los problemas. Posee una facultad promedio de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";
            if (IQ >= 65) return "Rango Bajo: El sujeto posee una inteligencia general bastante limitada. La persona presenta dificultades a la hora de comprender y resolver los problemas. Posee una limitada facultad de aprender, comprender y abstraer conceptos para luego aplicarlos a la resolución de problemas.";

            return string.Empty;
        }
    }
}
