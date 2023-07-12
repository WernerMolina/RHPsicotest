﻿using RHPsicotest.WebSite.Tests.Responses;
using System.Collections.Generic;
using System.Linq;

namespace RHPsicotest.WebSite.GenerateResults
{
    public class Results_PPGIPG
    {
        public static byte[] GetScoresByFactor(char[][] candidateResponses)
        {
            byte[] scoresByFactor = new byte[9];

            // Obtenemos las puntuaciones de la pregunta 1 a la 18
            char[,] responsesPPG = new char[18, 2];

            for (byte i = 0; i < 18; i++)
            {
                responsesPPG[i, 0] = candidateResponses[i][0];
                responsesPPG[i, 1] = candidateResponses[i][1];
            }

            // Obtenemos las puntuaciones de la pregunta 19 a la 38
            char[,] responsesIPG = new char[20, 2];

            for (int i = 0; i < 20; i++)
            {
                responsesIPG[i, 0] = candidateResponses[i + 18][0];
                responsesIPG[i, 1] = candidateResponses[i + 18][1];
            }

            for (byte i = 1; i <= 8; i++)
            {
                List<Responses_PPGIPG> responsesByFactor = Responses_PPGIPG.GetResponses().Where(r => r.IdFactor == i).ToList();

                if (i <= 4)
                {
                    byte scores = GetScoreByFactor(responsesPPG, responsesByFactor);

                    scoresByFactor[i - 1] = scores;
                }
                else
                {
                    byte scores = GetScoreByFactor(responsesIPG, responsesByFactor);

                    scoresByFactor[i - 1] = scores;
                }
            }

            // Suma para obtener el factor de Autoestima
            for (int i = 0; i <= 3; i++)
            {
                scoresByFactor[8] += scoresByFactor[i];
            }

            return scoresByFactor;
        }

        // Retorna el total de puntos de un factor
        private static byte GetScoreByFactor(char[,] candidateResponses, List<Responses_PPGIPG> responsesByFactor)
        {
            byte i = 0;
            byte score = 0;

            foreach (Responses_PPGIPG response in responsesByFactor)
            {
                if (response.Positive != null)
                {
                    if (candidateResponses[i, 0] == response.Positive) score += 2;
                    else if (candidateResponses[i, 1] == response.Positive) continue;
                    else score++;
                }
                else
                {
                    if (candidateResponses[i, 1] == response.Negative) score += 2;
                    else if (candidateResponses[i, 0] == response.Negative) continue;
                    else score++;
                }

                //char? correct = response.Positive;
                //char? incorrect = response.Negative;

                //bool a = false;
                //bool b = false;
                //bool c = false;
                //bool d = false;

                //if (correct.HasValue)
                //{
                //    switch (correct)
                //    {
                //        case 'A':
                //            a = true;
                //            break;
                //        case 'B':
                //            b = true;
                //            break;
                //        case 'C':
                //            c = true;
                //            break;
                //        case 'D':
                //            d = true;
                //            break;
                //    }
                //}
                //else
                //{
                //    a = true;
                //    b = true;
                //    c = true;
                //    d = true;

                //    switch (incorrect)
                //    {
                //        case 'A':
                //            a = false;
                //            break;
                //        case 'B':
                //            b = false;
                //            break;
                //        case 'C':
                //            c = false;
                //            break;
                //        case 'D':
                //            d = false;
                //            break;
                //    }
                //}

                //char positive = candidateResponses[i, 0];
                //char negative = candidateResponses[i, 1];

                //bool? ap = null;
                //bool? bp = null;
                //bool? cp = null;
                //bool? dp = null;

                //bool? an = null;
                //bool? bn = null;
                //bool? cn = null;
                //bool? dn = null;

                //switch (positive)
                //{
                //    case 'A':
                //        ap = true;
                //        break;
                //    case 'B':
                //        bp = true;
                //        break;
                //    case 'C':
                //        cp = true;
                //        break;
                //    case 'D':
                //        dp = true;
                //        break;
                //}

                //switch (negative)
                //{
                //    case 'A':
                //        an = false;
                //        break;
                //    case 'B':
                //        bn = false;
                //        break;
                //    case 'C':
                //        cn = false;
                //        break;
                //    case 'D':
                //        dn = false;
                //        break;
                //}

                //if (ap == a) score++;
                //if (bp == b) score++;
                //if (cp == c) score++;
                //if (dp == d) score++;

                //if (an == a) score++;
                //if (bn == b) score++;
                //if (cn == c) score++;
                //if (dn == d) score++;

                i++;
            }

            return score;
        }

        // Retorna un array con el percentil total de cada factor
        public static byte[] GetPercentilesByFactor(byte[] scoresByFactor, (string, byte, string) infoCandidate)
        {
            byte[] percentiles = new byte[9];

            if (infoCandidate.Item1 == "Hombre")
            {
                if (infoCandidate.Item2 < 20 || infoCandidate.Item3 == "Bachiller")
                {
                    percentiles = GetPercentile_YoungMan(scoresByFactor);
                }
                else
                {
                    percentiles = GetPercentile_AdultMan(scoresByFactor);
                }
            }

            if (infoCandidate.Item1 == "Mujer")
            {
                if (infoCandidate.Item2 < 20 || infoCandidate.Item3 == "Bachiller")
                {
                    percentiles = GetPercentile_YoungWoman(scoresByFactor);
                }
                else
                {
                    percentiles = GetPercentile_AdultWoman(scoresByFactor);
                }
            }

            return percentiles;
        }

        // Retorna un array con la descripción de cada factor
        public static string[] GetDescriptionsByPercentile(byte[] percentiles)
        {
            string[] descriptions = new string[9];

            descriptions[0] = GetDescription_Ascendencia(percentiles[0]);
            descriptions[1] = GetDescription_Responsabilidad(percentiles[1]);
            descriptions[2] = GetDescription_Estabilidad(percentiles[2]);
            descriptions[3] = GetDescription_Sociabilidad(percentiles[3]);
            descriptions[4] = GetDescription_Cautela(percentiles[4]);
            descriptions[5] = GetDescription_Originalidad(percentiles[5]);
            descriptions[6] = GetDescription_Comprension(percentiles[6]);
            descriptions[7] = GetDescription_Vitalidad(percentiles[7]);
            descriptions[8] = GetDescription_Autoestima(percentiles[8]);

            return descriptions;
        }

        // Estos metodos retornan un array con los percentiles de cada factor
        private static byte[] GetPercentile_YoungMan(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = GetPercentile_YoungMan_Ascendencia(scoresByFactor[0]);
            percentils[1] = GetPercentile_YoungMan_Responsabilidad(scoresByFactor[1]);
            percentils[2] = GetPercentile_YoungMan_Estabilidad(scoresByFactor[2]);
            percentils[3] = GetPercentile_YoungMan_Sociabilidad(scoresByFactor[3]);
            percentils[4] = GetPercentile_YoungMan_Cautela(scoresByFactor[4]);
            percentils[5] = GetPercentile_YoungMan_Originalidad(scoresByFactor[5]);
            percentils[6] = GetPercentile_YoungMan_Comprension(scoresByFactor[6]);
            percentils[7] = GetPercentile_YoungMan_Vitalidad(scoresByFactor[7]);
            percentils[8] = GetPercentile_YoungMan_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        private static byte[] GetPercentile_AdultMan(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = GetPercentile_AdultMan_Ascendencia(scoresByFactor[0]);
            percentils[1] = GetPercentile_AdultMan_Responsabilidad(scoresByFactor[1]);
            percentils[2] = GetPercentile_AdultMan_Estabilidad(scoresByFactor[2]);
            percentils[3] = GetPercentile_AdultMan_Sociabilidad(scoresByFactor[3]);
            percentils[4] = GetPercentile_AdultMan_Cautela(scoresByFactor[4]);
            percentils[5] = GetPercentile_AdultMan_Originalidad(scoresByFactor[5]);
            percentils[6] = GetPercentile_AdultMan_Comprension(scoresByFactor[6]);
            percentils[7] = GetPercentile_AdultMan_Vitalidad(scoresByFactor[7]);
            percentils[8] = GetPercentile_AdultMan_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        private static byte[] GetPercentile_YoungWoman(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = GetPercentile_YoungWoman_Ascendencia(scoresByFactor[0]);
            percentils[1] = GetPercentile_YoungWoman_Responsabilidad(scoresByFactor[1]);
            percentils[2] = GetPercentile_YoungWoman_Estabilidad(scoresByFactor[2]);
            percentils[3] = GetPercentile_YoungWoman_Sociabilidad(scoresByFactor[3]);
            percentils[4] = GetPercentile_YoungWoman_Cautela(scoresByFactor[4]);
            percentils[5] = GetPercentile_YoungWoman_Originalidad(scoresByFactor[5]);
            percentils[6] = GetPercentile_YoungWoman_Comprension(scoresByFactor[6]);
            percentils[7] = GetPercentile_YoungWoman_Vitalidad(scoresByFactor[7]);
            percentils[8] = GetPercentile_YoungWoman_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        private static byte[] GetPercentile_AdultWoman(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = GetPercentile_AdultWoman_Ascendencia(scoresByFactor[0]);
            percentils[1] = GetPercentile_AdultWoman_Responsabilidad(scoresByFactor[1]);
            percentils[2] = GetPercentile_AdultWoman_Estabilidad(scoresByFactor[2]);
            percentils[3] = GetPercentile_AdultWoman_Sociabilidad(scoresByFactor[3]);
            percentils[4] = GetPercentile_AdultWoman_Cautela(scoresByFactor[4]);
            percentils[5] = GetPercentile_AdultWoman_Originalidad(scoresByFactor[5]);
            percentils[6] = GetPercentile_AdultWoman_Comprension(scoresByFactor[6]);
            percentils[7] = GetPercentile_AdultWoman_Vitalidad(scoresByFactor[7]);
            percentils[8] = GetPercentile_AdultWoman_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        // Todos estos métodos nos retorna el percentil 

        // Tabla Hombres Mayores (20+ años) 
        private static byte GetPercentile_AdultMan_Ascendencia(byte score)
        {
            if (score >= 34) return 99;
            if (score == 33) return 98;
            if (score == 32) return 95;
            if (score == 31) return 90;
            if (score == 30) return 85;
            if (score == 29) return 80;
            if (score == 28) return 70;
            if (score == 27) return 60;
            if (score == 26) return 50;
            if (score == 25) return 35;
            if (score == 24) return 30;
            if (score == 23) return 20;
            if (score == 22) return 15;
            if (score == 21) return 10;
            if (score >= 19) return 5;
            if (score == 18) return 4;
            if (score == 17) return 3;
            if (score == 16) return 2;
            if (score <= 15) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Responsabilidad(byte score)
        {
            if (score >= 35) return 99;
            if (score == 34) return 98;
            if (score == 33) return 95;
            if (score == 32) return 90;
            if (score == 31) return 80;
            if (score == 30) return 75;
            if (score == 29) return 65;
            if (score == 28) return 50;
            if (score == 27) return 40;
            if (score == 26) return 30;
            if (score == 25) return 25;
            if (score == 24) return 15;
            if (score >= 22) return 10;
            if (score == 21) return 5;
            if (score == 20) return 3;
            if (score == 19) return 2;
            if (score <= 18) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Estabilidad(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 97;
            if (score == 31) return 95;
            if (score == 30) return 90;
            if (score == 29) return 80;
            if (score == 28) return 70;
            if (score == 27) return 60;
            if (score == 26) return 50;
            if (score == 25) return 45;
            if (score == 24) return 35;
            if (score == 23) return 25;
            if (score == 22) return 20;
            if (score == 21) return 15;
            if (score == 20) return 10;
            if (score == 19) return 5;
            if (score == 18) return 4;
            if (score == 17) return 3;
            if (score == 16) return 2;
            if (score <= 15) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Sociabilidad(byte score)
        {
            if (score >= 32) return 99;
            if (score == 31) return 97;
            if (score == 30) return 95;
            if (score == 29) return 90;
            if (score == 28) return 85;
            if (score == 27) return 80;
            if (score == 26) return 70;
            if (score == 25) return 65;
            if (score == 24) return 55;
            if (score == 23) return 45;
            if (score == 22) return 35;
            if (score == 21) return 25;
            if (score == 20) return 15;
            if (score == 19) return 10;
            if (score >= 17) return 5;
            if (score == 16) return 3;
            if (score >= 14) return 2;
            if (score <= 13) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Cautela(byte score)
        {
            if (score >= 32) return 99;
            if (score == 31) return 97;
            if (score == 30) return 90;
            if (score == 29) return 80;
            if (score == 28) return 75;
            if (score == 27) return 65;
            if (score == 26) return 55;
            if (score == 25) return 50;
            if (score == 24) return 40;
            if (score == 23) return 35;
            if (score == 22) return 30;
            if (score >= 20) return 25;
            if (score >= 18) return 20;
            if (score >= 7) return 15;
            if (score <= 6) return 10;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Originalidad(byte score)
        {
            if (score >= 37) return 99;
            if (score == 36) return 97;
            if (score == 35) return 95;
            if (score == 34) return 90;
            if (score == 33) return 80;
            if (score == 32) return 70;
            if (score == 31) return 65;
            if (score == 30) return 55;
            if (score == 29) return 45;
            if (score == 28) return 35;
            if (score == 27) return 25;
            if (score == 26) return 20;
            if (score == 25) return 15;
            if (score >= 23) return 10;
            if (score == 22) return 5;
            if (score == 21) return 4;
            if (score == 20) return 2;
            if (score <= 19) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Comprension(byte score)
        {
            if (score >= 35) return 99;
            if (score == 34) return 98;
            if (score == 33) return 96;
            if (score >= 31) return 90;
            if (score == 30) return 80;
            if (score == 29) return 75;
            if (score == 28) return 65;
            if (score == 27) return 50;
            if (score == 26) return 40;
            if (score == 25) return 35;
            if (score == 24) return 25;
            if (score == 23) return 15;
            if (score >= 21) return 10;
            if (score == 20) return 5;
            if (score == 19) return 3;
            if (score == 18) return 2;
            if (score <= 17) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Vitalidad(byte score)
        {
            if (score >= 36) return 99;
            if (score == 35) return 98;
            if (score == 34) return 96;
            if (score == 33) return 95;
            if (score == 32) return 90;
            if (score == 31) return 80;
            if (score == 30) return 70;
            if (score == 29) return 65;
            if (score == 28) return 55;
            if (score == 27) return 45;
            if (score == 26) return 35;
            if (score == 25) return 25;
            if (score == 24) return 20;
            if (score == 23) return 15;
            if (score == 22) return 10;
            if (score == 21) return 5;
            if (score == 20) return 4;
            if (score == 19) return 3;
            if (score == 18) return 2;
            if (score <= 17) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultMan_Autoestima(byte score)
        {
            if (score >= 114) return 99;
            if (score == 108) return 85;
            if (score == 107) return 70;
            if (score == 106) return 60;
            if (score == 105) return 50;
            if (score == 104) return 40;
            if (score == 103) return 35;
            if (score == 102) return 30;
            if (score == 101) return 25;
            if (score >= 99) return 20;
            if (score >= 96) return 15;
            if (score >= 91) return 10;
            if (score >= 86) return 5;
            if (score >= 84) return 4;
            if (score >= 82) return 3;
            if (score >= 77) return 2;
            if (score <= 76) return 1;


            return 0;
        }


        // Tabla Mujeres Mayores (20+ años)
        private static byte GetPercentile_AdultWoman_Ascendencia(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 96;
            if (score == 30) return 95;
            if (score == 29) return 90;
            if (score == 28) return 80;
            if (score == 27) return 70;
            if (score == 26) return 60;
            if (score == 25) return 50;
            if (score == 24) return 40;
            if (score == 23) return 30;
            if (score == 22) return 20;
            if (score == 21) return 15;
            if (score == 20) return 10;
            if (score >= 18) return 5;
            if (score == 17) return 4;
            if (score == 16) return 3;
            if (score == 15) return 2;
            if (score <= 14) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Responsabilidad(byte score)
        {
            if (score >= 35) return 99;
            if (score == 34) return 97;
            if (score == 33) return 95;
            if (score == 32) return 85;
            if (score == 31) return 80;
            if (score == 30) return 65;
            if (score == 29) return 55;
            if (score == 28) return 40;
            if (score == 27) return 30;
            if (score == 26) return 25;
            if (score == 25) return 15;
            if (score == 24) return 10;
            if (score >= 22) return 5;
            if (score == 21) return 3;
            if (score == 20) return 2;
            if (score <= 19) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Estabilidad(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 96;
            if (score == 30) return 90;
            if (score == 29) return 85;
            if (score == 28) return 80;
            if (score == 27) return 70;
            if (score == 26) return 65;
            if (score == 25) return 55;
            if (score == 24) return 40;
            if (score == 23) return 30;
            if (score == 22) return 25;
            if (score == 21) return 20;
            if (score == 20) return 15;
            if (score == 19) return 10;
            if (score >= 17) return 5;
            if (score == 16) return 3;
            if (score >= 14) return 2;
            if (score <= 13) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Sociabilidad(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 97;
            if (score == 30) return 95;
            if (score == 29) return 90;
            if (score == 28) return 85;
            if (score == 27) return 75;
            if (score == 26) return 70;
            if (score == 25) return 60;
            if (score == 24) return 50;
            if (score == 23) return 35;
            if (score == 22) return 25;
            if (score == 21) return 20;
            if (score == 20) return 15;
            if (score == 19) return 10;
            if (score == 18) return 5;
            if (score == 17) return 3;
            if (score >= 15) return 2;
            if (score <= 14) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Cautela(byte score)
        {
            if (score >= 32) return 99;
            if (score == 31) return 95;
            if (score == 30) return 85;
            if (score == 29) return 75;
            if (score == 28) return 70;
            if (score == 27) return 60;
            if (score == 26) return 50;
            if (score == 25) return 45;
            if (score == 24) return 35;
            if (score == 23) return 30;
            if (score == 22) return 25;
            if (score >= 20) return 20;
            if (score >= 15) return 15;
            if (score <= 14) return 10;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Originalidad(byte score)
        {
            if (score >= 37) return 99;
            if (score == 36) return 98;
            if (score == 35) return 96;
            if (score == 34) return 90;
            if (score == 33) return 85;
            if (score == 32) return 80;
            if (score == 31) return 70;
            if (score == 30) return 60;
            if (score == 29) return 50;
            if (score == 28) return 45;
            if (score == 27) return 35;
            if (score == 26) return 25;
            if (score == 25) return 20;
            if (score == 24) return 15;
            if (score == 23) return 10;
            if (score >= 21) return 5;
            if (score == 20) return 3;
            if (score == 19) return 2;
            if (score <= 18) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Comprension(byte score)
        {
            if (score >= 34) return 99;
            if (score == 33) return 97;
            if (score == 32) return 95;
            if (score == 31) return 90;
            if (score == 30) return 85;
            if (score == 29) return 80;
            if (score == 28) return 70;
            if (score == 27) return 55;
            if (score == 26) return 45;
            if (score == 25) return 35;
            if (score == 24) return 25;
            if (score == 23) return 20;
            if (score == 22) return 15;
            if (score == 21) return 10;
            if (score >= 19) return 5;
            if (score == 18) return 4;
            if (score >= 16) return 2;
            if (score <= 15) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Vitalidad(byte score)
        {
            if (score >= 36) return 99;
            if (score == 35) return 97;
            if (score == 34) return 95;
            if (score == 33) return 90;
            if (score == 32) return 85;
            if (score == 31) return 80;
            if (score == 30) return 70;
            if (score == 29) return 60;
            if (score == 28) return 50;
            if (score == 27) return 40;
            if (score == 26) return 30;
            if (score == 25) return 20;
            if (score == 24) return 15;
            if (score == 23) return 10;
            if (score >= 21) return 5;
            if (score == 20) return 4;
            if (score >= 18) return 2;
            if (score <= 17) return 1;

            return 0;
        }

        private static byte GetPercentile_AdultWoman_Autoestima(byte score)
        {
            if (score >= 114) return 99;
            if (score == 108) return 90;
            if (score == 107) return 75;
            if (score == 106) return 65;
            if (score == 105) return 55;
            if (score == 104) return 50;
            if (score == 103) return 40;
            if (score == 102) return 35;
            if (score == 101) return 30;
            if (score >= 99) return 25;
            if (score >= 97) return 20;
            if (score >= 94) return 15;
            if (score >= 90) return 10;
            if (score >= 86) return 5;
            if (score >= 83) return 4;
            if (score >= 80) return 3;
            if (score >= 76) return 2;
            if (score <= 75) return 1;

            return 0;
        }


        // Tabla Hombres Adolescentes (14-19 años) o Título Bachillerato
        private static byte GetPercentile_YoungMan_Ascendencia(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 96;
            if (score == 28) return 95;
            if (score == 27) return 90;
            if (score == 26) return 85;
            if (score == 25) return 80;
            if (score == 24) return 70;
            if (score == 23) return 65;
            if (score == 22) return 55;
            if (score == 21) return 50;
            if (score == 20) return 40;
            if (score == 19) return 35;
            if (score == 18) return 30;
            if (score == 17) return 20;
            if (score == 16) return 15;
            if (score >= 14) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score == 11) return 3;
            if (score == 10) return 2;
            if (score <= 9) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Responsabilidad(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 97;
            if (score == 28) return 95;
            if (score >= 26) return 90;
            if (score == 25) return 80;
            if (score == 24) return 75;
            if (score == 23) return 65;
            if (score == 22) return 60;
            if (score == 21) return 50;
            if (score == 20) return 45;
            if (score == 19) return 35;
            if (score == 18) return 30;
            if (score == 17) return 25;
            if (score == 16) return 20;
            if (score == 15) return 15;
            if (score == 14) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score == 11) return 3;
            if (score == 10) return 2;
            if (score <= 9) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Estabilidad(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 96;
            if (score == 28) return 95;
            if (score == 27) return 90;
            if (score == 26) return 85;
            if (score == 25) return 80;
            if (score == 24) return 75;
            if (score == 23) return 70;
            if (score == 22) return 60;
            if (score == 21) return 55;
            if (score == 20) return 45;
            if (score == 19) return 40;
            if (score == 18) return 35;
            if (score == 17) return 30;
            if (score == 16) return 25;
            if (score == 15) return 20;
            if (score == 14) return 15;
            if (score == 13) return 10;
            if (score >= 11) return 5;
            if (score == 10) return 3;
            if (score == 9) return 2;
            if (score <= 8) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Sociabilidad(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 97;
            if (score == 28) return 95;
            if (score == 27) return 90;
            if (score == 26) return 85;
            if (score == 25) return 80;
            if (score == 24) return 70;
            if (score == 23) return 65;
            if (score == 22) return 55;
            if (score == 21) return 45;
            if (score == 20) return 40;
            if (score == 19) return 30;
            if (score == 18) return 25;
            if (score == 17) return 20;
            if (score == 16) return 15;
            if (score >= 14) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score == 11) return 3;
            if (score == 10) return 2;
            if (score <= 9) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Cautela(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 97;
            if (score == 30) return 96;
            if (score == 29) return 95;
            if (score == 28) return 90;
            if (score >= 26) return 85;
            if (score == 25) return 80;
            if (score == 24) return 70;
            if (score == 23) return 65;
            if (score == 22) return 60;
            if (score == 21) return 50;
            if (score == 20) return 45;
            if (score == 19) return 35;
            if (score == 18) return 30;
            if (score == 17) return 25;
            if (score == 16) return 20;
            if (score == 15) return 15;
            if (score >= 13) return 10;
            if (score >= 11) return 5;
            if (score == 10) return 3;
            if (score == 9) return 2;
            if (score <= 8) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Originalidad(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 96;
            if (score == 30) return 95;
            if (score >= 28) return 90;
            if (score == 27) return 85;
            if (score == 26) return 75;
            if (score == 25) return 70;
            if (score == 24) return 60;
            if (score == 23) return 55;
            if (score == 22) return 45;
            if (score == 21) return 35;
            if (score == 20) return 30;
            if (score == 19) return 20;
            if (score == 18) return 15;
            if (score == 17) return 10;
            if (score == 16) return 5;
            if (score == 15) return 4;
            if (score == 14) return 2;
            if (score <= 13) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Comprension(byte score)
        {
            if (score >= 34) return 99;
            if (score == 33) return 98;
            if (score == 32) return 97;
            if (score == 31) return 96;
            if (score == 30) return 95;
            if (score == 29) return 90;
            if (score == 28) return 85;
            if (score == 27) return 80;
            if (score == 26) return 75;
            if (score == 25) return 70;
            if (score == 24) return 65;
            if (score == 23) return 55;
            if (score == 22) return 50;
            if (score == 21) return 40;
            if (score == 20) return 35;
            if (score == 19) return 30;
            if (score == 18) return 20;
            if (score >= 16) return 15;
            if (score == 15) return 10;
            if (score >= 13) return 5;
            if (score == 12) return 4;
            if (score == 11) return 3;
            if (score == 10) return 2;
            if (score <= 9) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Vitalidad(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 97;
            if (score >= 30) return 95;
            if (score == 29) return 90;
            if (score == 28) return 85;
            if (score == 27) return 80;
            if (score == 26) return 75;
            if (score == 25) return 65;
            if (score == 24) return 60;
            if (score == 23) return 50;
            if (score == 22) return 45;
            if (score == 21) return 35;
            if (score == 20) return 30;
            if (score == 19) return 25;
            if (score == 18) return 20;
            if (score == 17) return 15;
            if (score >= 15) return 10;
            if (score == 14) return 5;
            if (score == 13) return 3;
            if (score == 12) return 2;
            if (score <= 11) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungMan_Autoestima(byte score)
        {
            if (score >= 107) return 99;
            if (score >= 105) return 98;
            if (score == 104) return 97;
            if (score == 103) return 96;
            if (score == 102) return 95;
            if (score >= 99) return 90;
            if (score >= 97) return 85;
            if (score >= 94) return 80;
            if (score >= 92) return 75;
            if (score >= 90) return 70;
            if (score == 89) return 65;
            if (score >= 87) return 60;
            if (score >= 85) return 55;
            if (score >= 83) return 50;
            if (score >= 81) return 45;
            if (score >= 79) return 40;
            if (score == 78) return 35;
            if (score >= 75) return 30;
            if (score >= 73) return 25;
            if (score >= 70) return 20;
            if (score >= 67) return 15;
            if (score >= 63) return 10;
            if (score >= 59) return 5;
            if (score >= 57) return 4;
            if (score >= 55) return 3;
            if (score >= 51) return 2;
            if (score <= 50) return 1;


            return 0;
        }


        // Tabla Mujeres Adolescentes (14-19 años) o Título Bachillerato
        private static byte GetPercentile_YoungWoman_Ascendencia(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 96;
            if (score == 28) return 95;
            if (score == 27) return 90;
            if (score == 26) return 85;
            if (score == 25) return 80;
            if (score == 24) return 70;
            if (score == 23) return 65;
            if (score == 22) return 55;
            if (score == 21) return 50;
            if (score == 20) return 40;
            if (score == 19) return 35;
            if (score == 18) return 30;
            if (score == 17) return 25;
            if (score == 16) return 20;
            if (score == 15) return 15;
            if (score >= 13) return 10;
            if (score >= 11) return 5;
            if (score == 10) return 4;
            if (score == 9) return 3;
            if (score == 8) return 2;
            if (score <= 7) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Responsabilidad(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 97;
            if (score == 28) return 95;
            if (score == 27) return 90;
            if (score == 26) return 85;
            if (score == 25) return 80;
            if (score == 24) return 75;
            if (score == 23) return 70;
            if (score == 22) return 60;
            if (score == 21) return 55;
            if (score == 20) return 45;
            if (score == 19) return 40;
            if (score == 18) return 30;
            if (score == 17) return 25;
            if (score == 16) return 20;
            if (score == 15) return 15;
            if (score == 14) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score == 11) return 3;
            if (score == 10) return 2;
            if (score <= 9) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Estabilidad(byte score)
        {
            if (score >= 30) return 99;
            if (score == 29) return 98;
            if (score == 28) return 97;
            if (score == 27) return 95;
            if (score >= 25) return 90;
            if (score == 24) return 85;
            if (score == 23) return 80;
            if (score == 22) return 75;
            if (score == 21) return 65;
            if (score == 20) return 60;
            if (score == 19) return 55;
            if (score == 18) return 45;
            if (score == 17) return 40;
            if (score == 16) return 30;
            if (score == 15) return 25;
            if (score == 14) return 20;
            if (score == 13) return 15;
            if (score >= 11) return 10;
            if (score == 10) return 5;
            if (score == 9) return 4;
            if (score == 8) return 3;
            if (score <= 7) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Sociabilidad(byte score)
        {
            if (score >= 32) return 99;
            if (score == 31) return 98;
            if (score == 30) return 96;
            if (score == 29) return 90;
            if (score == 28) return 85;
            if (score == 27) return 80;
            if (score == 26) return 75;
            if (score == 25) return 65;
            if (score == 24) return 60;
            if (score == 23) return 50;
            if (score == 22) return 45;
            if (score == 21) return 35;
            if (score == 20) return 30;
            if (score == 19) return 25;
            if (score == 18) return 20;
            if (score == 17) return 15;
            if (score >= 15) return 10;
            if (score >= 13) return 5;
            if (score == 12) return 4;
            if (score >= 10) return 2;
            if (score <= 9) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Cautela(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 96;
            if (score >= 29) return 95;
            if (score == 28) return 90;
            if (score == 27) return 85;
            if (score == 26) return 80;
            if (score == 25) return 75;
            if (score == 24) return 70;
            if (score == 23) return 65;
            if (score == 22) return 60;
            if (score == 21) return 50;
            if (score == 20) return 45;
            if (score == 19) return 40;
            if (score == 18) return 35;
            if (score == 17) return 30;
            if (score >= 15) return 25;
            if (score == 14) return 20;
            if (score == 13) return 15;
            if (score >= 11) return 10;
            if (score == 10) return 5;
            if (score == 9) return 4;
            if (score == 8) return 3;
            if (score == 7) return 2;
            if (score <= 6) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Originalidad(byte score)
        {
            if (score >= 33) return 99;
            if (score == 32) return 98;
            if (score == 31) return 97;
            if (score == 30) return 95;
            if (score == 29) return 90;
            if (score == 28) return 85;
            if (score == 27) return 80;
            if (score == 26) return 75;
            if (score == 25) return 65;
            if (score == 24) return 60;
            if (score == 23) return 50;
            if (score == 22) return 40;
            if (score == 21) return 35;
            if (score == 20) return 25;
            if (score == 19) return 20;
            if (score == 18) return 15;
            if (score >= 16) return 10;
            if (score == 15) return 5;
            if (score == 14) return 3;
            if (score == 13) return 2;
            if (score <= 12) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Comprension(byte score)
        {
            if (score == 40) return 99;
            if (score >= 35) return 97;
            if (score >= 33) return 96;
            if (score >= 31) return 95;
            if (score == 30) return 90;
            if (score >= 28) return 85;
            if (score == 27) return 80;
            if (score == 26) return 75;
            if (score == 25) return 70;
            if (score == 24) return 60;
            if (score == 23) return 55;
            if (score == 22) return 50;
            if (score == 21) return 40;
            if (score == 20) return 35;
            if (score == 19) return 30;
            if (score == 18) return 25;
            if (score == 17) return 20;
            if (score == 16) return 15;
            if (score >= 14) return 10;
            if (score == 13) return 5;
            if (score == 12) return 3;
            if (score == 11) return 2;
            if (score <= 10) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Vitalidad(byte score)
        {
            if (score >= 32) return 99;
            if (score == 31) return 98;
            if (score == 30) return 96;
            if (score >= 28) return 90;
            if (score == 27) return 85;
            if (score == 26) return 75;
            if (score == 25) return 70;
            if (score == 24) return 60;
            if (score == 23) return 55;
            if (score == 22) return 45;
            if (score == 21) return 40;
            if (score == 20) return 30;
            if (score == 19) return 25;
            if (score == 18) return 20;
            if (score == 17) return 15;
            if (score >= 15) return 10;
            if (score >= 13) return 5;
            if (score == 12) return 4;
            if (score >= 10) return 3;
            if (score >= 7) return 2;
            if (score <= 6) return 1;

            return 0;
        }

        private static byte GetPercentile_YoungWoman_Autoestima(byte score)
        {
            if (score >= 106) return 99;
            if (score == 105) return 98;
            if (score >= 103) return 97;
            if (score >= 101) return 95;
            if (score >= 98) return 90;
            if (score >= 96) return 85;
            if (score >= 94) return 80;
            if (score >= 92) return 75;
            if (score == 91) return 70;
            if (score >= 89) return 65;
            if (score >= 87) return 60;
            if (score >= 85) return 55;
            if (score >= 83) return 50;
            if (score >= 81) return 45;
            if (score >= 79) return 40;
            if (score >= 77) return 35;
            if (score >= 74) return 30;
            if (score >= 72) return 25;
            if (score >= 69) return 20;
            if (score >= 65) return 15;
            if (score >= 60) return 10;
            if (score >= 56) return 5;
            if (score >= 54) return 4;
            if (score >= 52) return 3;
            if (score >= 48) return 2;
            if (score <= 47) return 1;

            return 0;
        }


        // Métodos para obtener la descripción de cada factor
        private static string GetDescription_Ascendencia(byte percentile)
        {
            if (percentile >= 71) return "Alto: Toma la iniciativa en discusiones de grupo. Verbalmente activo. Capaz de tomar decisiones importantes sin ayuda. Le resulta fácil influir en los demás. Persona segura de sí mismo. Autoafirmativo en las relaciones con los demás.";
            if (percentile >= 41) return "Promedio: Esta persona tiene un comportamiento promedio en cuanto a su papel en el grupo, a la seguridad en sí misma, a sus relaciones con los demás y a la toma de decisiones independientes.";
            if (percentile >= 1) return "Bajo: Prefiere que otros tomen la iniciativa en las actividades del grupo, no se siente muy seguro(a) de sus opiniones. Tiende a escuchar más que hablar, tiene poca autoconfianza, carece de seguridad en sí mismo.";

            return string.Empty;
        }

        private static string GetDescription_Responsabilidad(byte percentile)
        {
            if (percentile >= 71) return "Alto: Concluye su trabajo a pesar de los problemas, cumple con cualquier trabajo que se le asigna, aunque no sean de su agrado e interés, los demás se sienten seguros de confiar en él. Es trabajador, persistente y tenaz.";
            if (percentile >= 41) return "Promedio: Esta persona tiene un grado de responsabilidad que corresponde con el promedio, en cuanto a perseverancia, decisión y confianza, así como en la estabilidad en cualquier trabajo que se le asigna.";
            if (percentile >= 1) return "Bajo: No puede realizar la misma tarea por mucho tiempo, no persevera, es inestable e irresponsable, persona poco confiable.";

            return string.Empty;
        }

        private static string GetDescription_Estabilidad(byte percentile)
        {
            if (percentile >= 71) return "Alto: Es calmado(a) y fácil de tratar, se siente libre de preocupaciones, ansiedades y tensión nerviosa, le resulta fácil relajarse. Es equilibrada y con una buena tolerancia a la frustración.";
            if (percentile >= 41) return " Promedio: Esta persona tiene una evaluación promedio como persona equilibrada, emotivamente estable y relativamente libre de ansiedades y de tensión nerviosa.";
            if (percentile >= 1) return "Bajo: Siempre parece preocupado(a), tiende a ser una persona nerviosa. Se disgusta fácilmente si las cosas van mal. Baja tolerancia a la frustración. Puede reflejar un ajuste emocional deficiente.";

            return string.Empty;
        }

        private static string GetDescription_Sociabilidad(byte percentile)
        {
            if (percentile >= 71) return "Alto: Le gusta estar y trabajar con otras personas gregarias y sociables, se le facilita hacer nuevas amistades. Le gusta estar y trabajar con otros.";
            if (percentile >= 41) return "Promedio: Esta persona tiene una actitud promedio como persona sociable y gregaria, a quien gusta hallarse entre la gente con quien trabaja.";
            if (percentile >= 1) return "Bajo: Falta de una tendencia gregaria, tiende a evitar las relaciones sociales o de grupo, restringe sus conocidos a unos cuantos. En casos extremos puede haber una evitación real de toda relación social.";

            return string.Empty;
        }

        private static string GetDescription_Cautela(byte percentile)
        {
            if (percentile >= 71) return "Alto: Persona muy precavida, considera todos los detalles o situaciones cuidadosamente antes de tomar una decisión, no le gusta arriesgarse o decidir a la ligera, ni tomar decisiones precipitadas o repentinas.";
            if (percentile >= 41) return "Promedio: Es un individuo cauteloso y cuidadoso, aunque no en extremo, antes de tomar decisiones en sus asuntos. En general mantiene una actitud cuidadosa al probar oportunidades o correr riesgos.";
            if (percentile >= 1) return "Bajo: Busca lo emocionante y excitante, actúa impulsivamente, le gusta arriesgarse, toma decisiones precipitadas o repentinas, actúa en forma aventurada.";

            return string.Empty;
        }

        private static string GetDescription_Originalidad(byte percentile)
        {
            if (percentile >= 71) return "Alto: Le gusta trabajar en problemas o tareas difíciles, intelectualmente curioso, gusta de preguntas y discusiones que llevan a la reflexión y a pensar en nuevas ideas, a veces complicadas.";
            if (percentile >= 41) return "Promedio: Se considera una persona promedio en cuanto a originalidad, lo que se refleja en su trabajo en problemas difíciles, su curiosidad intelectual y participación en cuestiones y discusiones que hacen pensar, en las que aporta nuevas ideas.";
            if (percentile >= 1) return "Bajo: Le disgusta trabajar en problemas difíciles o complicados, no le interesa adquirir nuevos conocimientos, ni participar de preguntas o discusiones que lo lleven a reflexionar.";

            return string.Empty;
        }

        private static string GetDescription_Comprension(byte percentile)
        {
            if (percentile >= 71) return "Alto: Tiene fe y confianza en la gente, habla lo mejor de los demás, es tolerante, paciente y comprensivo.";
            if (percentile >= 41) return "Promedio: Esta persona mantiene unas relaciones personales dentro del promedio, conserva la fe y confianza en la gente. Se puede considerar una persona tolerante, paciente y comprensiva.";
            if (percentile >= 1) return "Bajo: Pierde la paciencia con los demás rápidamente, le irrita o molesta lo que hacen o hablan los demás.";

            return string.Empty;
        }

        private static string GetDescription_Vitalidad(byte percentile)
        {
            if (percentile >= 71) return "Alto: Poseé vitalidad y energía, gusta de trabajar y moverse con rapidez, capaz de realizar más que la persona promedio.";
            if (percentile >= 41) return "Promedio: Esta persona se encuentra en la media en cuanto a su trabajo, por ser vigorosa, enérgica y ágil.";
            if (percentile >= 1) return "Bajo: Posee poca vitalidad e impulso, prefiere un ritmo lento o se cansa fácilmente, sus resultados o rendimiento es menor.";

            return string.Empty;
        }

        private static string GetDescription_Autoestima(byte percentile)
        {
            if (percentile >= 71) return "Alto: Piensa bien de sí mismo(a). Persona activa, seguro(a), responsable, confiable, tranquila y sociable. Capaz de enfrentar la vida con fortaleza.";
            if (percentile >= 41) return "Promedio: Esta persona tiene una evaluación promedio dentro de esta escala.";
            if (percentile >= 1) return "Bajo: Bajo concepto de sí mismo, aislado(a) e inseguro(a), no digno de confianza, irresponsable, desadaptado, perfeccionista.";

            return string.Empty;
        }
    }
}
