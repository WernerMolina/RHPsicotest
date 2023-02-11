using RHPsicotest.WebSite.Models;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.Utilities
{
    public class GenerateResults
    {
        // Retorna el total de puntos de un factor
        public static byte GetPointsByFactor(char[,] candidateResponses, IEnumerable<Response> responsesByFactor)
        {
            int i = 0;
            byte points = 0;

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

                if (ap == a) points++;
                if (bp == b) points++;
                if (cp == c) points++;
                if (dp == d) points++;

                if (an == a) points++;
                if (bn == b) points++;
                if (cn == c) points++;
                if (dn == d) points++;

                i++;
            }

            return points;
        }

        public static int[] GetPercentileByFactor(int[] scoreFactor, (string, byte) infoCandidate)
        {
            if(infoCandidate.Item1 == "Hombre")
            {
                
            }
            
            if(infoCandidate.Item1 == "Mujer")
            {

            }

        }

        //private int[] TableTeenageMan(int[] scoreFactor)
        //{

        //}

        //private int[] TableHombreAdulto(int[] scoreFactor)
        //{
        //    for (int i = 0; i < scoreFactor.Length; i++)
        //    {
        //        if (i == 0) ; 
        //    }
        //}

        //private int[] TableTeenageWoman(int[] scoreFactor)
        //{

        //}

        //private int[] TableAdultWoman(int[] scoreFactor)
        //{

        //}


        // Tabla Hombres Mayores (21 años) 
        private int HombreAdulto_Ascendencia(int score)
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
        
        private int HombreAdulto_Responsabilidad(int score)
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
        
        private int HombreAdulto_Estabilidad(int score)
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
        
        private int HombreAdulto_Sociabilidad(int score)
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
        
        private int HombreAdulto_Cautela(int score)
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

        private int HombreAdulto_Originalidad(int score)
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

        private int HombreAdulto_Comprension(int score)
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

        private int HombreAdulto_Vitalidad(int score)
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

        private int HombreAdulto_Autoestima(int score)
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


        // Tabla Mujeres Mayores (21 años)
        private int MujerAdulta_Ascendencia(int score)
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

        private int MujerAdulta_Responsabilidad(int score)
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

        private int MujerAdulta_Estabilidad(int score)
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

        private int MujerAdulta_Sociabilidad(int score)
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

        private int MujerAdulta_Cautela(int score)
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

        private int MujerAdulta_Originalidad(int score)
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

        private int MujerAdulta_Comprension(int score)
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

        private int MujerAdulta_Vitalidad(int score)
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

        private int MujerAdulta_Autoestima(int score)
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


        // Tabla Hombres Adolescentes (14-20 años) o Título Bachillerato
        private int HombreJoven_Ascendencia(int score)
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

        private int HombreJoven_Responsabilidad(int score)
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

        private int HombreJoven_Estabilidad(int score)
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

        private int HombreJoven_Sociabilidad(int score)
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

        private int HombreJoven_Cautela(int score)
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

        private int HombreJoven_Originalidad(int score)
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

        private int HombreJoven_Comprension(int score)
        {
            if (score >= 34) return 99;
            if (score == 33) return 98;
            if (score == 33) return 97;
            if (score == 32) return 96;
            if (score == 31) return 95;
            if (score == 30) return 90;
            if (score == 29) return 85;
            if (score == 28) return 80;
            if (score == 27) return 75;
            if (score == 26) return 70;
            if (score == 25) return 65;
            if (score == 24) return 55;
            if (score == 23) return 50;
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

        private int HombreJoven_Vitalidad(int score)
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

        private int HombreJoven_Autoestima(int score)
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
        private int MUjerJoven_Ascendencia(int score)
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

        private int MujerJoven_Responsabilidad(int score)
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

        private int MujerJoven_Estabilidad(int score)
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

        private int MujerJoven_Sociabilidad(int score)
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

        private int MujerJoven_Cautela(int score)
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

        private int MujerJoven_Originalidad(int score)
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

        private int MujerJoven_Comprension(int score)
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

        private int MujerJoven_Vitalidad(int score)
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

        private int MujerJoven_Autoestima(int score)
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
