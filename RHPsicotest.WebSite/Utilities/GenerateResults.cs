using RHPsicotest.WebSite.Models;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.Utilities
{
    public class GenerateResults
    {
        // Retorna el total de puntos de un factor
        public static byte GetScoreByFactor(char[,] candidateResponses, IEnumerable<Response> responsesByFactor)
        {
            byte i = 0;
            byte score = 0;

            foreach (Response response in responsesByFactor)
            {
                string correct = response.Correct;
                string incorrect = response.Incorrect;

                bool a = false;
                bool b = false;
                bool c = false;
                bool d = false;

                if (correct.Length == 1)
                {
                    switch (correct)
                    {
                        case "A":
                            a = true;
                            break;
                        case "B":
                            b = true;
                            break;
                        case "C":
                            c = true;
                            break;
                        case "D":
                            d = true;
                            break;
                    }
                }
                else
                {
                    switch (incorrect)
                    {
                        case "A":
                            b = true;
                            c = true;
                            d = true;
                            break;
                        case "B":
                            a = true;
                            c = true;
                            d = true;
                            break;
                        case "C":
                            a = true;
                            b = true;
                            d = true;
                            break;
                        case "D":
                            a = true;
                            b = true;
                            c = true;
                            break;
                    }
                }

                char positive = candidateResponses[i, 0];
                char negative = candidateResponses[i, 1];

                bool? ap = null;
                bool? bp = null;
                bool? cp = null;
                bool? dp = null;

                bool? an = null;
                bool? bn = null;
                bool? cn = null;
                bool? dn = null;

                switch (positive)
                {
                    case 'A':
                        ap = true;
                        break;
                    case 'B':
                        bp = true;
                        break;
                    case 'C':
                        cp = true;
                        break;
                    case 'D':
                        dp = true;
                        break;
                }

                switch (negative)
                {
                    case 'A':
                        an = false;
                        break;
                    case 'B':
                        bn = false;
                        break;
                    case 'C':
                        cn = false;
                        break;
                    case 'D':
                        dn = false;
                        break;
                }

                if (ap == a) score++;
                if (bp == b) score++;
                if (cp == c) score++;
                if (dp == d) score++;

                if (an == a) score++;
                if (bn == b) score++;
                if (cn == c) score++;
                if (dn == d) score++;

                i++;
            }

            return score;
        }

        public static byte[] GetPercentileByFactor(byte[] scoresByFactor, (string, byte, string) infoCandidate)
        {
            byte[] percentils = new byte[9];

            if(infoCandidate.Item1 == "Hombre")
            {
                if(infoCandidate.Item2 <= 20 || infoCandidate.Item3 == "Bachillerato")
                {
                    percentils = TablaHombreJoven(scoresByFactor);
                }
                else
                {
                    percentils = TablaHombreAdulto(scoresByFactor);
                }
            }
            
            if(infoCandidate.Item1 == "Mujer")
            {
                if (infoCandidate.Item2 <= 20 || infoCandidate.Item3 == "Bachillerato")
                {
                    percentils = TablaMujerJoven(scoresByFactor);
                }
                else
                {
                    percentils = TablaMujerAdulta(scoresByFactor);
                }
            }


            return percentils;
        }
 
        private static byte[] TablaHombreJoven(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = HombreJoven_Ascendencia(scoresByFactor[0]);
            percentils[1] = HombreJoven_Responsabilidad(scoresByFactor[1]);
            percentils[2] = HombreJoven_Estabilidad(scoresByFactor[2]);
            percentils[3] = HombreJoven_Sociabilidad(scoresByFactor[3]);
            percentils[4] = HombreJoven_Cautela(scoresByFactor[4]);
            percentils[5] = HombreJoven_Originalidad(scoresByFactor[5]);
            percentils[6] = HombreJoven_Comprension(scoresByFactor[6]);
            percentils[7] = HombreJoven_Vitalidad(scoresByFactor[7]);
            percentils[8] = HombreJoven_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        private static byte[] TablaHombreAdulto(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = HombreAdulto_Ascendencia(scoresByFactor[0]);
            percentils[1] = HombreAdulto_Responsabilidad(scoresByFactor[1]);
            percentils[2] = HombreAdulto_Estabilidad(scoresByFactor[2]);
            percentils[3] = HombreAdulto_Sociabilidad(scoresByFactor[3]);
            percentils[4] = HombreAdulto_Cautela(scoresByFactor[4]);
            percentils[5] = HombreAdulto_Originalidad(scoresByFactor[5]);
            percentils[6] = HombreAdulto_Comprension(scoresByFactor[6]);
            percentils[7] = HombreAdulto_Vitalidad(scoresByFactor[7]);
            percentils[8] = HombreAdulto_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        private static byte[] TablaMujerJoven(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = MujerJoven_Ascendencia(scoresByFactor[0]);
            percentils[1] = MujerJoven_Responsabilidad(scoresByFactor[1]);
            percentils[2] = MujerJoven_Estabilidad(scoresByFactor[2]);
            percentils[3] = MujerJoven_Sociabilidad(scoresByFactor[3]);
            percentils[4] = MujerJoven_Cautela(scoresByFactor[4]);
            percentils[5] = MujerJoven_Originalidad(scoresByFactor[5]);
            percentils[6] = MujerJoven_Comprension(scoresByFactor[6]);
            percentils[7] = MujerJoven_Vitalidad(scoresByFactor[7]);
            percentils[8] = MujerJoven_Autoestima(scoresByFactor[8]);

            return percentils;
        }

        private static byte[] TablaMujerAdulta(byte[] scoresByFactor)
        {
            byte[] percentils = new byte[9];

            percentils[0] = MujerJoven_Ascendencia(scoresByFactor[0]);
            percentils[1] = MujerJoven_Responsabilidad(scoresByFactor[1]);
            percentils[2] = MujerJoven_Estabilidad(scoresByFactor[2]);
            percentils[3] = MujerJoven_Sociabilidad(scoresByFactor[3]);
            percentils[4] = MujerJoven_Cautela(scoresByFactor[4]);
            percentils[5] = MujerJoven_Originalidad(scoresByFactor[5]);
            percentils[6] = MujerJoven_Comprension(scoresByFactor[6]);
            percentils[7] = MujerJoven_Vitalidad(scoresByFactor[7]);
            percentils[8] = MujerJoven_Autoestima(scoresByFactor[8]);

            return percentils;
        }


        // Tabla Hombres Mayores (21+ años) 
        private static byte HombreAdulto_Ascendencia(byte score)
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

        private static byte HombreAdulto_Responsabilidad(byte score)
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

        private static byte HombreAdulto_Estabilidad(byte score)
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

        private static byte HombreAdulto_Sociabilidad(byte score)
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

        private static byte HombreAdulto_Cautela(byte score)
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

        private static byte HombreAdulto_Originalidad(byte score)
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

        private static byte HombreAdulto_Comprension(byte score)
        {
            if (score >= 35) return 99;
            if (score == 34) return 98;
            if (score == 33) return 95;
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

        private static byte HombreAdulto_Vitalidad(byte score)
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

        private static byte HombreAdulto_Autoestima(byte score)
        {
            if (score == 114) return 99;
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


        // Tabla Mujeres Mayores (21+ años)
        private static byte MujerAdulta_Ascendencia(byte score)
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

        private static byte MujerAdulta_Responsabilidad(byte score)
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

        private static byte MujerAdulta_Estabilidad(byte score)
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

        private static byte MujerAdulta_Sociabilidad(byte score)
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

        private static byte MujerAdulta_Cautela(byte score)
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

        private static byte MujerAdulta_Originalidad(byte score)
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

        private static byte MujerAdulta_Comprension(byte score)
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

        private static byte MujerAdulta_Vitalidad(byte score)
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

        private byte MujerAdulta_Autoestima(byte score)
        {
            if (score == 114) return 99;
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
        private static byte HombreJoven_Ascendencia(byte score)
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

        private static byte HombreJoven_Responsabilidad(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 97;
            if (score == 28) return 95;
            if (score >= 26) return 90;
            if (score == 25) return 80;
            if (score == 24) return 75;
            if (score == 23) return 70;
            if (score == 22) return 60;
            if (score == 21) return 55;
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

        private static byte HombreJoven_Estabilidad(byte score)
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

        private static byte HombreJoven_Sociabilidad(byte score)
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

        private static byte HombreJoven_Cautela(byte score)
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

        private static byte HombreJoven_Originalidad(byte score)
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

        private static byte HombreJoven_Comprension(byte score)
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

        private static byte HombreJoven_Vitalidad(byte score)
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

        private static byte HombreJoven_Autoestima(byte score)
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



        // Tabla Mujeres Adolescentes (14-20 años) o Título Bachillerato
        private static byte MujerJoven_Ascendencia(byte score)
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

        private static byte MujerJoven_Responsabilidad(byte score)
        {
            if (score >= 31) return 99;
            if (score == 30) return 98;
            if (score == 29) return 97;
            if (score == 28) return 90;
            if (score == 27) return 85;
            if (score == 26) return 80;
            if (score == 25) return 75;
            if (score == 24) return 70;
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

        private static byte MujerJoven_Estabilidad(byte score)
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

        private static byte MujerJoven_Sociabilidad(byte score)
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

        private static byte MujerJoven_Cautela(byte score)
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

        private static byte MujerJoven_Originalidad(byte score)
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

        private static byte MujerJoven_Comprension(byte score)
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

        private static byte MujerJoven_Vitalidad(byte score)
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

        private static byte MujerJoven_Autoestima(byte score)
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

    }
}
