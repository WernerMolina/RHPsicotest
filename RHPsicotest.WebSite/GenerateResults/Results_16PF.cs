using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Tests.Responses;
using System;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.GenerateResults
{
    public class Results_16PF
    {
        public static byte[] GetScoreByFactor(char[] responsesCandidate)
        {
            byte[] scoresByFactor = new byte[16];

            List<Responses_16PF> responses_16PF = Responses_16PF.GetResponses();

            byte factorId = 1;
            byte scoreTotal = 0;

            foreach (Responses_16PF response in responses_16PF)
            {
                char option = responsesCandidate[--response.QuestionNumber];

                byte score = response.AnswerOptions[option];

                if (factorId == response.IdFactor)
                {
                    scoreTotal += score;
                }
                else
                {
                    scoresByFactor[--factorId] = scoreTotal;

                    factorId = response.IdFactor;

                    scoreTotal = 0;

                    scoreTotal += score;
                }
            }

            return scoresByFactor;
        }

        public static byte[] GetDecatypeByFactor(byte[] scoresByFactor, string gender, bool isWayA)
        {
            byte[] decatypes = new byte[16];

            if (isWayA)
            {
                if (gender == "Hombre")
                    decatypes = WayA_TableMan(scoresByFactor);
                else
                    decatypes = WayA_TableWoman(scoresByFactor);
            }
            else
            {
                if (gender == "Hombre")
                    decatypes = WayB_TableMan(scoresByFactor);
                else
                    decatypes = WayB_TableWoman(scoresByFactor);
            }

            return decatypes;
        }

        public static byte[] GetScoreOfSecondaryFactors(byte[] decatypes, string gender)
        {
            byte[] scores = new byte[4];

            scores[0] = FactorAnxiety(decatypes, gender);
            scores[1] = FactorExtraversion(decatypes, gender);
            scores[2] = FactorSocialization(decatypes, gender);
            scores[3] = FactorIndependence(decatypes, gender);

            return scores;
        }
        
        // Descripciones por factor
        public static string[] GetDescriptionsPrimaryFactors(byte[] decatypes)
        {
            string[] descriptions = new string[16];

            descriptions[0] = Description_FactorA(decatypes[0]);
            descriptions[1] = Description_FactorB(decatypes[1]);
            descriptions[2] = Description_FactorC(decatypes[2]);
            descriptions[3] = Description_FactorE(decatypes[3]);
            descriptions[4] = Description_FactorF(decatypes[4]);
            descriptions[5] = Description_FactorG(decatypes[5]);
            descriptions[6] = Description_FactorH(decatypes[6]);
            descriptions[7] = Description_FactorI(decatypes[7]);
            descriptions[8] = Description_FactorL(decatypes[8]);
            descriptions[9] = Description_FactorM(decatypes[9]);
            descriptions[10] = Description_FactorN(decatypes[10]);
            descriptions[11] = Description_FactorO(decatypes[11]);
            descriptions[12] = Description_FactorQ1(decatypes[12]);
            descriptions[13] = Description_FactorQ2(decatypes[13]);
            descriptions[14] = Description_FactorQ3(decatypes[14]);
            descriptions[15] = Description_FactorQ4(decatypes[15]);

            return descriptions;
        }
        
        public static string[] GetDescriptionsSecondaryFactors(byte[] decatypes)
        {
            string[] descriptions = new string[16];

            descriptions[0] = Description_FactorA(decatypes[0]);
            descriptions[1] = Description_FactorB(decatypes[1]);
            descriptions[2] = Description_FactorC(decatypes[2]);
            descriptions[3] = Description_FactorE(decatypes[3]);

            return descriptions;
        }

        // Tabla de la Forma A
        private static byte[] WayA_TableMan(byte[] scoresByFactor)
        {
            byte[] decatypes = new byte[16];

            decatypes[0] = WayA_Man_FactorA(scoresByFactor[0]);
            decatypes[1] = WayA_Man_FactorB(scoresByFactor[1]);
            decatypes[2] = WayA_Man_FactorC(scoresByFactor[2]);
            decatypes[3] = WayA_Man_FactorE(scoresByFactor[3]);
            decatypes[4] = WayA_Man_FactorF(scoresByFactor[4]);
            decatypes[5] = WayA_Man_FactorG(scoresByFactor[5]);
            decatypes[6] = WayA_Man_FactorH(scoresByFactor[6]);
            decatypes[7] = WayA_Man_FactorI(scoresByFactor[7]);
            decatypes[8] = WayA_Man_FactorL(scoresByFactor[8]);
            decatypes[9] = WayA_Man_FactorM(scoresByFactor[9]);
            decatypes[10] = WayA_Man_FactorN(scoresByFactor[10]);
            decatypes[11] = WayA_Man_FactorO(scoresByFactor[11]);
            decatypes[12] = WayA_Man_FactorQ1(scoresByFactor[12]);
            decatypes[13] = WayA_Man_FactorQ2(scoresByFactor[13]);
            decatypes[14] = WayA_Man_FactorQ3(scoresByFactor[14]);
            decatypes[15] = WayA_Man_FactorQ4(scoresByFactor[15]);

            return decatypes;
        }

        private static byte[] WayA_TableWoman(byte[] scoresByFactor)
        {
            byte[] decatypes = new byte[16];

            decatypes[0] = WayA_Woman_FactorA(scoresByFactor[0]);
            decatypes[1] = WayA_Woman_FactorB(scoresByFactor[1]);
            decatypes[2] = WayA_Woman_FactorC(scoresByFactor[2]);
            decatypes[3] = WayA_Woman_FactorE(scoresByFactor[3]);
            decatypes[4] = WayA_Woman_FactorF(scoresByFactor[4]);
            decatypes[5] = WayA_Woman_FactorG(scoresByFactor[5]);
            decatypes[6] = WayA_Woman_FactorH(scoresByFactor[6]);
            decatypes[7] = WayA_Woman_FactorI(scoresByFactor[7]);
            decatypes[8] = WayA_Woman_FactorL(scoresByFactor[8]);
            decatypes[9] = WayA_Woman_FactorM(scoresByFactor[9]);
            decatypes[10] = WayA_Woman_FactorN(scoresByFactor[10]);
            decatypes[11] = WayA_Woman_FactorO(scoresByFactor[11]);
            decatypes[12] = WayA_Woman_FactorQ1(scoresByFactor[12]);
            decatypes[13] = WayA_Woman_FactorQ2(scoresByFactor[13]);
            decatypes[14] = WayA_Woman_FactorQ3(scoresByFactor[14]);
            decatypes[15] = WayA_Woman_FactorQ4(scoresByFactor[15]);

            return decatypes;
        }

        // Tabla de la Forma B
        private static byte[] WayB_TableMan(byte[] scoresByFactor)
        {
            byte[] decatypes = new byte[16];

            decatypes[0] = WayB_Man_FactorA(scoresByFactor[0]);
            decatypes[1] = WayB_Man_FactorB(scoresByFactor[1]);
            decatypes[2] = WayB_Man_FactorC(scoresByFactor[2]);
            decatypes[3] = WayB_Man_FactorE(scoresByFactor[3]);
            decatypes[4] = WayB_Man_FactorF(scoresByFactor[4]);
            decatypes[5] = WayB_Man_FactorG(scoresByFactor[5]);
            decatypes[6] = WayB_Man_FactorH(scoresByFactor[6]);
            decatypes[7] = WayB_Man_FactorI(scoresByFactor[7]);
            decatypes[8] = WayB_Man_FactorL(scoresByFactor[8]);
            decatypes[9] = WayB_Man_FactorM(scoresByFactor[9]);
            decatypes[10] = WayB_Man_FactorN(scoresByFactor[10]);
            decatypes[11] = WayB_Man_FactorO(scoresByFactor[11]);
            decatypes[12] = WayB_Man_FactorQ1(scoresByFactor[12]);
            decatypes[13] = WayB_Man_FactorQ2(scoresByFactor[13]);
            decatypes[14] = WayB_Man_FactorQ3(scoresByFactor[14]);
            decatypes[15] = WayB_Man_FactorQ4(scoresByFactor[15]);

            return decatypes;
        }

        private static byte[] WayB_TableWoman(byte[] scoresByFactor)
        {
            byte[] decatypes = new byte[16];

            decatypes[0] = WayB_Woman_FactorA(scoresByFactor[0]);
            decatypes[1] = WayB_Woman_FactorB(scoresByFactor[1]);
            decatypes[2] = WayB_Woman_FactorC(scoresByFactor[2]);
            decatypes[3] = WayB_Woman_FactorE(scoresByFactor[3]);
            decatypes[4] = WayB_Woman_FactorF(scoresByFactor[4]);
            decatypes[5] = WayB_Woman_FactorG(scoresByFactor[5]);
            decatypes[6] = WayB_Woman_FactorH(scoresByFactor[6]);
            decatypes[7] = WayB_Woman_FactorI(scoresByFactor[7]);
            decatypes[8] = WayB_Woman_FactorL(scoresByFactor[8]);
            decatypes[9] = WayB_Woman_FactorM(scoresByFactor[9]);
            decatypes[10] = WayB_Woman_FactorN(scoresByFactor[10]);
            decatypes[11] = WayB_Woman_FactorO(scoresByFactor[11]);
            decatypes[12] = WayB_Woman_FactorQ1(scoresByFactor[12]);
            decatypes[13] = WayB_Woman_FactorQ2(scoresByFactor[13]);
            decatypes[14] = WayB_Woman_FactorQ3(scoresByFactor[14]);
            decatypes[15] = WayB_Woman_FactorQ4(scoresByFactor[15]);

            return decatypes;
        }

        // Factores de la Forma A Hombre
        private static byte WayA_Man_FactorA(byte score)
        {
            if (score >= 19) return 10;
            if (score >= 17) return 9;
            if (score == 16) return 8;
            if (score >= 14) return 7;
            if (score == 13) return 6;
            if (score >= 11) return 5;
            if (score == 10) return 4;
            if (score >= 8) return 3;
            if (score == 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorB(byte score)
        {
            if (score == 13) return 10;
            if (score == 12) return 9;
            if (score == 11) return 8;
            if (score == 10) return 7;
            if (score == 9) return 6;
            if (score == 8) return 5;
            if (score >= 6) return 4;
            if (score == 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorC(byte score)
        {
            if (score >= 25) return 10;
            if (score >= 23) return 9;
            if (score >= 21) return 8;
            if (score >= 18) return 7;
            if (score >= 16) return 6;
            if (score >= 14) return 5;
            if (score >= 11) return 4;
            if (score >= 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorE(byte score)
        {
            if (score >= 20) return 10;
            if (score == 19) return 9;
            if (score >= 16) return 8;
            if (score >= 14) return 7;
            if (score >= 12) return 6;
            if (score >= 10) return 5;
            if (score == 9) return 4;
            if (score >= 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorF(byte score)
        {
            if (score >= 24) return 10;
            if (score >= 22) return 9;
            if (score >= 20) return 8;
            if (score >= 18) return 7;
            if (score >= 16) return 6;
            if (score >= 14) return 5;
            if (score >= 11) return 4;
            if (score >= 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorG(byte score)
        {
            if (score == 20) return 10;
            if (score == 19) return 9;
            if (score == 18) return 8;
            if (score == 17) return 7;
            if (score >= 15) return 6;
            if (score >= 13) return 5;
            if (score >= 11) return 4;
            if (score >= 9) return 3;
            if (score == 8) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorH(byte score)
        {
            if (score >= 25) return 10;
            if (score >= 23) return 9;
            if (score >= 21) return 8;
            if (score >= 19) return 7;
            if (score >= 16) return 6;
            if (score >= 13) return 5;
            if (score >= 10) return 4;
            if (score >= 7) return 3;
            if (score >= 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorI(byte score)
        {
            if (score >= 18) return 10;
            if (score >= 16) return 9;
            if (score >= 14) return 8;
            if (score == 13) return 7;
            if (score >= 11) return 6;
            if (score >= 9) return 5;
            if (score >= 7) return 4;
            if (score >= 5) return 3;
            if (score >= 3) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorL(byte score)
        {
            if (score >= 17) return 10;
            if (score >= 15) return 9;
            if (score >= 13) return 8;
            if (score == 12) return 7;
            if (score >= 10) return 6;
            if (score == 9) return 5;
            if (score >= 7) return 4;
            if (score == 6) return 3;
            if (score >= 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorM(byte score)
        {
            if (score >= 18) return 10;
            if (score == 17) return 9;
            if (score >= 15) return 8;
            if (score >= 13) return 7;
            if (score == 12) return 6;
            if (score >= 10) return 5;
            if (score == 9) return 4;
            if (score >= 7) return 3;
            if (score == 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorN(byte score)
        {
            if (score >= 16) return 10;
            if (score == 15) return 9;
            if (score == 14) return 8;
            if (score >= 12) return 7;
            if (score == 11) return 6;
            if (score == 10) return 5;
            if (score >= 8) return 4;
            if (score == 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorO(byte score)
        {
            if (score >= 19) return 10;
            if (score >= 17) return 9;
            if (score >= 15) return 8;
            if (score >= 13) return 7;
            if (score >= 11) return 6;
            if (score >= 9) return 5;
            if (score >= 7) return 4;
            if (score >= 5) return 3;
            if (score >= 3) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorQ1(byte score)
        {
            if (score >= 16) return 10;
            if (score == 15) return 9;
            if (score >= 13) return 8;
            if (score >= 11) return 7;
            if (score == 10) return 6;
            if (score >= 8) return 5;
            if (score == 7) return 4;
            if (score == 6) return 3;
            if (score >= 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorQ2(byte score)
        {
            if (score >= 17) return 10;
            if (score >= 15) return 9;
            if (score == 14) return 8;
            if (score >= 12) return 7;
            if (score >= 10) return 6;
            if (score >= 8) return 5;
            if (score == 7) return 4;
            if (score >= 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorQ3(byte score)
        {
            if (score >= 19) return 10;
            if (score == 18) return 9;
            if (score == 17) return 8;
            if (score >= 15) return 7;
            if (score >= 13) return 6;
            if (score == 12) return 5;
            if (score >= 10) return 4;
            if (score >= 8) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Man_FactorQ4(byte score)
        {
            if (score >= 20) return 10;
            if (score >= 18) return 9;
            if (score >= 15) return 8;
            if (score >= 13) return 7;
            if (score >= 10) return 6;
            if (score >= 7) return 5;
            if (score >= 4) return 4;
            if (score == 3) return 3;
            if (score >= 1) return 2;
            if (score == 0) return 1;

            return 0;
        }


        // Factores de la Forma A Mujer
        private static byte WayA_Woman_FactorA(byte score)
        {
            if (score >= 19) return 10;
            if (score >= 17) return 9;
            if (score == 16) return 8;
            if (score >= 14) return 7;
            if (score == 13) return 6;
            if (score >= 11) return 5;
            if (score == 10) return 4;
            if (score >= 8) return 3;
            if (score == 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorB(byte score)
        {
            if (score == 13) return 10;
            if (score == 12) return 9;
            if (score == 11) return 8;
            if (score == 10) return 7;
            if (score == 9) return 6;
            if (score == 8) return 5;
            if (score == 7) return 4;
            if (score >= 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorC(byte score)
        {
            if (score >= 24) return 10;
            if (score >= 22) return 9;
            if (score >= 20) return 8;
            if (score >= 18) return 7;
            if (score >= 16) return 6;
            if (score >= 13) return 5;
            if (score >= 11) return 4;
            if (score >= 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorE(byte score)
        {
            if (score >= 19) return 10;
            if (score >= 17) return 9;
            if (score >= 15) return 8;
            if (score >= 13) return 7;
            if (score >= 11) return 6;
            if (score == 10) return 5;
            if (score >= 8) return 4;
            if (score >= 6) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorF(byte score)
        {
            if (score >= 24) return 10;
            if (score == 23) return 9;
            if (score >= 21) return 8;
            if (score >= 19) return 7;
            if (score >= 16) return 6;
            if (score >= 14) return 5;
            if (score >= 12) return 4;
            if (score >= 10) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorG(byte score)
        {
            if (score == 20) return 10;
            if (score == 19) return 9;
            if (score == 18) return 8;
            if (score == 17) return 7;
            if (score >= 15) return 6;
            if (score >= 13) return 5;
            if (score >= 11) return 4;
            if (score >= 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorH(byte score)
        {
            if (score >= 25) return 10;
            if (score >= 23) return 9;
            if (score >= 21) return 8;
            if (score >= 19) return 7;
            if (score >= 16) return 6;
            if (score >= 13) return 5;
            if (score >= 10) return 4;
            if (score >= 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorI(byte score)
        {
            if (score >= 19) return 10;
            if (score == 18) return 9;
            if (score == 17) return 8;
            if (score == 16) return 7;
            if (score >= 14) return 6;
            if (score >= 12) return 5;
            if (score >= 10) return 4;
            if (score == 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorL(byte score)
        {
            if (score >= 17) return 10;
            if (score >= 15) return 9;
            if (score == 14) return 8;
            if (score >= 12) return 7;
            if (score == 11) return 6;
            if (score >= 9) return 5;
            if (score >= 7) return 4;
            if (score >= 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorM(byte score)
        {
            if (score >= 18) return 10;
            if (score >= 16) return 9;
            if (score == 15) return 8;
            if (score >= 13) return 7;
            if (score >= 11) return 6;
            if (score == 10) return 5;
            if (score >= 8) return 4;
            if (score >= 6) return 3;
            if (score == 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorN(byte score)
        {
            if (score >= 17) return 10;
            if (score == 16) return 9;
            if (score >= 14) return 8;
            if (score == 13) return 7;
            if (score == 12) return 6;
            if (score >= 10) return 5;
            if (score == 9) return 4;
            if (score == 8) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorO(byte score)
        {
            if (score >= 21) return 10;
            if (score >= 19) return 9;
            if (score >= 17) return 8;
            if (score >= 15) return 7;
            if (score >= 13) return 6;
            if (score >= 10) return 5;
            if (score >= 8) return 4;
            if (score >= 6) return 3;
            if (score >= 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorQ1(byte score)
        {
            if (score >= 16) return 10;
            if (score >= 14) return 9;
            if (score == 13) return 8;
            if (score >= 11) return 7;
            if (score == 10) return 6;
            if (score >= 8) return 5;
            if (score >= 6) return 4;
            if (score == 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorQ2(byte score)
        {
            if (score >= 18) return 10;
            if (score >= 16) return 9;
            if (score >= 14) return 8;
            if (score >= 12) return 7;
            if (score >= 10) return 6;
            if (score == 9) return 5;
            if (score >= 7) return 4;
            if (score == 6) return 3;
            if (score >= 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorQ3(byte score)
        {
            if (score >= 19) return 10;
            if (score == 18) return 9;
            if (score >= 16) return 8;
            if (score == 15) return 7;
            if (score >= 13) return 6;
            if (score >= 11) return 5;
            if (score >= 9) return 4;
            if (score >= 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayA_Woman_FactorQ4(byte score)
        {
            if (score >= 22) return 10;
            if (score >= 20) return 9;
            if (score >= 18) return 8;
            if (score >= 15) return 7;
            if (score >= 12) return 6;
            if (score >= 9) return 5;
            if (score >= 6) return 4;
            if (score >= 4) return 3;
            if (score >= 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }


        // Factores de la Forma B Hombre
        private static byte WayB_Man_FactorA(byte score)
        {
            if (score >= 19) return 10;
            if (score >= 17) return 9;
            if (score >= 15) return 8;
            if (score >= 13) return 7;
            if (score >= 11) return 6;
            if (score >= 9) return 5;
            if (score >= 7) return 4;
            if (score >= 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorB(byte score)
        {
            if (score >= 12) return 10;
            if (score == 11) return 9;
            if (score == 10) return 7;
            if (score == 9) return 6;
            if (score == 8) return 5;
            if (score >= 6) return 4;
            if (score == 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorC(byte score)
        {
            if (score == 26) return 10;
            if (score >= 24) return 9;
            if (score >= 22) return 8;
            if (score >= 20) return 7;
            if (score >= 18) return 6;
            if (score >= 16) return 5;
            if (score >= 14) return 4;
            if (score >= 12) return 3;
            if (score >= 10) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorE(byte score)
        {
            if (score >= 21) return 10;
            if (score >= 19) return 9;
            if (score == 18) return 8;
            if (score >= 16) return 7;
            if (score >= 14) return 6;
            if (score >= 12) return 5;
            if (score == 11) return 4;
            if (score >= 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorF(byte score)
        {
            if (score >= 21) return 10;
            if (score >= 19) return 9;
            if (score >= 17) return 8;
            if (score >= 15) return 7;
            if (score >= 13) return 6;
            if (score >= 11) return 5;
            if (score == 10) return 4;
            if (score >= 8) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorG(byte score)
        {
            if (score == 20) return 10;
            if (score == 19) return 9;
            if (score == 18) return 8;
            if (score == 17) return 7;
            if (score == 16) return 6;
            if (score == 15) return 5;
            if (score >= 13) return 4;
            if (score >= 11) return 3;
            if (score == 10) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorH(byte score)
        {
            if (score == 26) return 10;
            if (score == 25) return 9;
            if (score >= 23) return 8;
            if (score >= 21) return 7;
            if (score >= 19) return 6;
            if (score >= 16) return 5;
            if (score >= 13) return 4;
            if (score >= 9) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorI(byte score)
        {
            if (score >= 17) return 10;
            if (score >= 15) return 9;
            if (score >= 13) return 8;
            if (score == 12) return 7;
            if (score >= 10) return 6;
            if (score >= 8) return 5;
            if (score == 7) return 4;
            if (score >= 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorL(byte score)
        {
            if (score >= 16) return 10;
            if (score >= 14) return 9;
            if (score >= 12) return 8;
            if (score == 11) return 7;
            if (score >= 9) return 6;
            if (score == 8) return 5;
            if (score >= 6) return 4;
            if (score == 5) return 3;
            if (score >= 3) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorM(byte score)
        {
            if (score >= 20) return 10;
            if (score >= 18) return 9;
            if (score >= 16) return 8;
            if (score >= 14) return 7;
            if (score >= 12) return 6;
            if (score == 11) return 5;
            if (score >= 9) return 4;
            if (score >= 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorN(byte score)
        {
            if (score >= 17) return 10;
            if (score == 16) return 9;
            if (score == 15) return 8;
            if (score == 14) return 7;
            if (score >= 12) return 6;
            if (score == 11) return 5;
            if (score >= 9) return 4;
            if (score == 8) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorO(byte score)
        {
            if (score >= 19) return 10;
            if (score >= 16) return 9;
            if (score >= 13) return 8;
            if (score >= 10) return 7;
            if (score >= 7) return 6;
            if (score >= 5) return 5;
            if (score >= 3) return 4;
            if (score == 2) return 3;
            if (score == 1) return 2;
            if (score == 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorQ1(byte score)
        {
            if (score >= 16) return 10;
            if (score == 15) return 9;
            if (score == 14) return 8;
            if (score >= 12) return 7;
            if (score == 11) return 6;
            if (score >= 9) return 5;
            if (score == 8) return 4;
            if (score == 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorQ2(byte score)
        {
            if (score >= 14) return 10;
            if (score == 13) return 9;
            if (score >= 11) return 8;
            if (score == 10) return 7;
            if (score >= 8) return 6;
            if (score == 7) return 5;
            if (score >= 5) return 4;
            if (score == 4) return 3;
            if (score == 3) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorQ3(byte score)
        {
            if (score >= 19) return 10;
            if (score == 18) return 9;
            if (score == 17) return 8;
            if (score == 16) return 7;
            if (score >= 14) return 6;
            if (score == 13) return 5;
            if (score >= 11) return 4;
            if (score == 10) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Man_FactorQ4(byte score)
        {
            if (score >= 18) return 10;
            if (score >= 15) return 9;
            if (score >= 13) return 8;
            if (score >= 10) return 7;
            if (score >= 7) return 6;
            if (score >= 5) return 5;
            if (score >= 3) return 4;
            if (score == 0) return 3;
            if (score == 1) return 2;
            if (score == 0) return 1;

            return 0;
        }


        // Factores de la Forma B Mujer
        private static byte WayB_Woman_FactorA(byte score)
        {
            if (score >= 18) return 10;
            if (score >= 16) return 9;
            if (score >= 14) return 8;
            if (score >= 12) return 7;
            if (score == 11) return 6;
            if (score >= 9) return 5;
            if (score == 8) return 4;
            if (score >= 6) return 3;
            if (score == 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorB(byte score)
        {
            if (score == 13) return 10;
            if (score == 12) return 9;
            if (score == 11) return 8;
            if (score == 10) return 7;
            if (score == 9) return 6;
            if (score >= 7) return 5;
            if (score == 6) return 4;
            if (score == 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorC(byte score)
        {
            if (score >= 22) return 10;
            if (score == 21) return 9;
            if (score >= 19) return 8;
            if (score >= 16) return 7;
            if (score >= 14) return 6;
            if (score >= 12) return 5;
            if (score >= 10) return 4;
            if (score >= 8) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorE(byte score)
        {
            if (score >= 21) return 10;
            if (score >= 19) return 9;
            if (score >= 17) return 8;
            if (score >= 15) return 7;
            if (score >= 13) return 6;
            if (score >= 11) return 5;
            if (score >= 9) return 4;
            if (score >= 7) return 3;
            if (score >= 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorF(byte score)
        {
            if (score >= 23) return 10;
            if (score >= 21) return 9;
            if (score >= 19) return 8;
            if (score >= 17) return 7;
            if (score >= 15) return 6;
            if (score >= 12) return 5;
            if (score >= 10) return 4;
            if (score == 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorG(byte score)
        {
            if (score == 20) return 10;
            if (score == 19) return 9;
            if (score == 18) return 8;
            if (score >= 16) return 7;
            if (score == 15) return 6;
            if (score >= 13) return 5;
            if (score >= 11) return 4;
            if (score == 10) return 3;
            if (score >= 8) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorH(byte score)
        {
            if (score >= 25) return 10;
            if (score >= 23) return 9;
            if (score >= 20) return 8;
            if (score >= 17) return 7;
            if (score >= 13) return 6;
            if (score >= 10) return 5;
            if (score >= 7) return 4;
            if (score >= 5) return 3;
            if (score >= 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorI(byte score)
        {
            if (score >= 19) return 10;
            if (score == 18) return 9;
            if (score >= 16) return 8;
            if (score == 15) return 7;
            if (score >= 13) return 6;
            if (score == 12) return 5;
            if (score >= 10) return 4;
            if (score == 9) return 3;
            if (score >= 7) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorL(byte score)
        {
            if (score >= 17) return 10;
            if (score >= 14) return 9;
            if (score == 13) return 8;
            if (score >= 11) return 7;
            if (score >= 9) return 6;
            if (score >= 7) return 5;
            if (score == 6) return 4;
            if (score == 5) return 3;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorM(byte score)
        {
            if (score >= 21) return 10;
            if (score >= 19) return 9;
            if (score >= 17) return 8;
            if (score == 16) return 7;
            if (score >= 14) return 6;
            if (score >= 12) return 5;
            if (score >= 10) return 4;
            if (score >= 8) return 3;
            if (score >= 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorN(byte score)
        {
            if (score >= 17) return 10;
            if (score >= 15) return 9;
            if (score == 14) return 8;
            if (score >= 12) return 7;
            if (score == 11) return 6;
            if (score >= 9) return 5;
            if (score == 8) return 4;
            if (score >= 6) return 3;
            if (score == 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorO(byte score)
        {
            if (score >= 22) return 10;
            if (score >= 20) return 9;
            if (score >= 18) return 8;
            if (score >= 16) return 7;
            if (score >= 13) return 6;
            if (score >= 10) return 5;
            if (score >= 8) return 4;
            if (score >= 4) return 3;
            if (score == 3) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorQ1(byte score)
        {
            if (score >= 17) return 10;
            if (score == 16) return 9;
            if (score >= 14) return 8;
            if (score >= 12) return 7;
            if (score == 11) return 6;
            if (score == 10) return 5;
            if (score == 9) return 4;
            if (score >= 7) return 3;
            if (score == 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorQ2(byte score)
        {
            if (score >= 15) return 10;
            if (score >= 13) return 9;
            if (score == 12) return 8;
            if (score >= 10) return 7;
            if (score == 9) return 6;
            if (score == 8) return 5;
            if (score == 7) return 4;
            if (score >= 5) return 3;
            if (score >= 3) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorQ3(byte score)
        {
            if (score >= 17) return 10;
            if (score == 16) return 9;
            if (score >= 14) return 8;
            if (score == 13) return 7;
            if (score >= 11) return 6;
            if (score >= 9) return 5;
            if (score == 8) return 4;
            if (score >= 6) return 3;
            if (score == 5) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte WayB_Woman_FactorQ4(byte score)
        {
            if (score >= 24) return 10;
            if (score >= 22) return 9;
            if (score >= 19) return 8;
            if (score >= 16) return 7;
            if (score >= 14) return 6;
            if (score >= 11) return 5;
            if (score >= 8) return 4;
            if (score >= 5) return 3;
            if (score >= 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        // Factores de segundo orden
        public static byte FactorAnxiety(byte[] decatypes, string gender)
        {
            int positive, negative;

            if (gender == "Hombre")
            {
                positive = decatypes[0] + decatypes[7] + (decatypes[8] * 2) + (decatypes[11] * 3) + (decatypes[15] * 3) + 46;

                negative = (decatypes[2] * 3) + (decatypes[6] * 2) + decatypes[9] + decatypes[14];
            }
            else
            {
                positive = decatypes[5] + (decatypes[8] * 2) + (decatypes[11] * 3) + (decatypes[15] * 3) + 51;

                negative = (decatypes[2] * 3) + (decatypes[6] * 2) + decatypes[9] + decatypes[14];
            }

            return Convert.ToByte(positive - negative);
        }

        public static byte FactorExtraversion(byte[] decatypes, string gender)
        {
            int positive, negative;

            if (gender == "Hombre")
            {
                positive = (decatypes[0] * 4) + decatypes[3] + (decatypes[4] * 3) + (decatypes[5] * 2) + (decatypes[6] * 3) + decatypes[7] + decatypes[8] + decatypes[14] + decatypes[15] + 2;

                negative = decatypes[1] + decatypes[2] + decatypes[9] + (decatypes[13] * 4);
            }
            else
            {
                positive = (decatypes[0] * 5) + (decatypes[3] * 3) + (decatypes[4] * 3) + decatypes[5] + (decatypes[6] * 3) + (decatypes[7] * 5) + decatypes[13] + decatypes[14];

                negative = decatypes[2] + decatypes[7] + decatypes[9] + 47;
            }

            return Convert.ToByte(positive - negative);
        }

        public static byte FactorSocialization(byte[] decatypes, string gender)
        {
            int positive, negative;

            if (gender == "Hombre")
            {
                // Factor A + Factor E + Factor F + Factor G + Factor H + Factor I + Factor L + Factor Q3 + Factor Q4 + 2
                positive = decatypes[0] + (decatypes[1] * 3) + (decatypes[5] * 4) + decatypes[7] + (decatypes[10] * 4) + (decatypes[14] * 3) + 23;

                // Factor B + Factor C + Factor M + Factor Q2
                negative = decatypes[2] + (decatypes[3] * 2) + (decatypes[4] * 3) + decatypes[6] + decatypes[9] + decatypes[15];
            }
            else
            {
                // Factor G + Factor L + Factor O + Factor Q4 + 51
                positive = decatypes[0] + (decatypes[1] * 2) + (decatypes[5] * 4) + decatypes[8] + (decatypes[10] * 3) + (decatypes[14] * 3) + 22;

                // Factor C + Factor H + Factor M + Factor Q3
                negative = decatypes[2] + (decatypes[3] * 2) + (decatypes[4] * 2) + decatypes[6] + decatypes[9] + decatypes[12] + decatypes[15];
            }

            return Convert.ToByte(positive - negative);
        }

        public static byte FactorIndependence(byte[] decatypes, string gender)
        {
            int positive, negative;

            if (gender == "Hombre")
            {
                // Factor A + Factor E + Factor F + Factor G + Factor H + Factor I + Factor L + Factor Q3 + Factor Q4 + 2
                positive = (decatypes[1] * 5) + (decatypes[4] * 3) + (decatypes[8] * 3) + decatypes[9] + decatypes[10] + (decatypes[12] * 4) + decatypes[13];

                // Factor B + Factor C + Factor M + Factor Q2
                negative = decatypes[11] + 46;
            }
            else
            {
                // Factor G + Factor L + Factor O + Factor Q4 + 51
                positive = (decatypes[1] + 6) + (decatypes[3] * 2) + decatypes[5] + decatypes[7] + decatypes[8] + (decatypes[9] * 3) + (decatypes[12] * 4) + decatypes[14];

                // Factor C + Factor H + Factor M + Factor Q3
                negative = (decatypes[0] * 2) + decatypes[10] + decatypes[13] + 31;
            }

            return Convert.ToByte(positive - negative);
        }


        // Descripciones
        private static string Description_FactorA(byte decatype)
        {
            if (decatype >= 5)
                return "Sizotimia: La persona que puntúa bajo tiende a ser dura, fría, indiferente y se mantiene alejada. Le gustan más las cosas que las personas, trabajar en solitario y evitar las opiniones comprometidas. Suele ser precisa y rígida en su manera de hacer las cosas y en sus criterios personales, rasgos que son deseables en muchas ocupaciones. En ocasiones puede ser critica, obstaculizadora e inflexible.";
            if (decatype >= 0)
                return "Afectomia: La persona que puntúa alto tiende a ser amable, tranquila, emocionalmente expresiva dispuesta a cooperar, solicita con lo demás, bondadosa, amable y adaptable. Le gustan las ocupaciones que exijan contactos con la gente y las situaciones de relación social. Fácilmente forma parte de grupos activos, es generosa en sus relaciones personales, poco temerosa de las críticas y bastante capaz de recordar los nombres de las personas.";

            return string.Empty;
        }

        private static string Description_FactorB(byte decatype)
        {
            if (decatype >= 5)
                return "Mucha capacidad mental para los estudios: La persona que puntúa alto tiende a ser rápida en su comprensión y aprendizaje de las ideas. Existe alguna relación con el nivel cultural y con la viveza mental. En una situación de diagnóstico psicopatológico, estas puntuaciones altas contraindican la existencia de un deterioro mental.";
            if (decatype >= 0)
                return "Poca capacidad mental para los estudios: La persona que puntúa bajo tiende a ser lenta para aprender y captar cosas, corta e inclinada a interpretaciones concretas y literales. Su cortedad puede ser debida a una escasa capacidad intelectual o a la influencia de factores psicopatológicos que limitan su actuación.";

            return string.Empty;
        }

        private static string Description_FactorC(byte decatype)
        {
            if (decatype >= 5)
                return "Mucha fuerza de ego: La persona que puntúa alto tiende a ser emocionalmente madura, estable, realista acerca de la vida, tranquila, con buena firmeza interior y capacidad para mantener una solida moral de grupo. A veces puede presentar ajustes conformistas en el caso de problemas no resueltos.";
            if (decatype >= 0)
                return "Poca fuerza de ego: La persona que puntúa bajo tiende a presentar poca tolerancia a la frustración; cuando las condiciones no son satisfactorias es inestable, evade las necesidades y llamadas de la realidad. Neuróticamente fatigada, indiferente, de emoción y perturbación fácil, activa cuando se encuentra insatisfecha; presenta síntomas neuróticos (fobias, alteraciones del sueño, quejas psicosomáticas, etc.).";

            return string.Empty;
        }

        private static string Description_FactorE(byte decatype)
        {
            if (decatype >= 5)
                return "Dominancia: La persona que puntúa alto es dogmática, segura de sí misma, de mentalidad independiente. Tiende a ser austera, autoreguladora, hostil y extrapunitiva, autoritaria (en el manejo de los demás), y a hacer caso omiso de toda autoridad.";
            if (decatype >= 0)
                return "Sumisión: La persona que puntúa bajo tiende a ceder ante los demás, a ser dócil, y a conformarse. Es, a menudo, independiente, acepta las ideas de los otros, y se muestra ansiosa por una exactitud obsesiva. Esta pasividad es parte de muchos síndromes neuróticos.";

            return string.Empty;
        }

        private static string Description_FactorF(byte decatype)
        {
            if (decatype >= 5)
                return "Surgencia: La persona que puntúa alto tiende a ser jovial, activa, charlatana, franca, expresiva, acalorada y descuidada. Frecuentemente se le escoge como líder electo. Puede ser impulsiva y de actividad imprevisible o cambiante.";
            if (decatype >= 0)
                return "Desurgencia: La persona que puntúa bajo tiende a ser reprimida, desconfiada e introspectiva. A veces es terca, pesimista, indebidamente cauta; es considerada por lo demás como presumida y estiradamente correcta. Suele ser una persona discreta y digna de confianza.";

            return string.Empty;
        }

        private static string Description_FactorG(byte decatype)
        {
            if (decatype >= 5)
                return "Mucha fuerza de superego: La persona que puntúa alto tiende a ser de carácter exigente, dominada por el sentido del deber, perseverante, responsable, organizada, y a “no malgasta un minuto”. Normalmente es escrupulosa y moralista. Más que a tipos graciosos, prefiere como compañeros a personas trabajadoras.";
            if (decatype >= 0)
                return "Poca fuerza de superego: La persona que puntúa bajo suele ser inestable en sus propósitos. Sus acciones son casuales y faltas de atención a los compromisos del grupo y las exigencias culturales. Su alejamiento de la influencia del grupo puede llevarle a actos antisociales, lo cual le hace ser más efectiva, a la vez que su negativa unión a las normas le permite tener menos conflictos somáticos en situaciones de tensión.";

            return string.Empty;
        }

        private static string Description_FactorH(byte decatype)
        {
            if (decatype >= 5)
                return "Parmia: La persona que puntúa alto tiende a ser sociable, atrevida, dispuesta a intentar nuevas cosas, espontanea, de numerosas respuestas emocionales. Su indiferencia (falta de vergüenza) le permite soportar sin fatiga el “toma y dame” del trato con la gente y las situaciones emocionales abrumadoras. Sin embargo, puede despreocuparse por los detalles, e invertir mucho tiempo charlando. Tiende a ser emprendedora y estar activamente interesada por el otro sexo.";
            if (decatype >= 0)
                return "Trectia: La persona que puntúa bajo suele ser tímida, alejada, cautelosa, retraída, que permanece al margen de la actividad social. Puede presentar sentimientos de inferioridad. Tiende a ser lenta y torpe al hablar y expresarse, no le gustan las ocupaciones con contactos personales. Mas que un grupo amplio, prefiere uno o dos amigos íntimos, y no es dada a mantenerse en contacto con todo lo que está ocurriendo a su alrededor.";

            return string.Empty;
        }

        private static string Description_FactorI(byte decatype)
        {
            if (decatype >= 5)
                return "Premisa: La persona que puntúa alto suele dejarse afectar por los sentimientos, idealistas, soñadora, artista, insatisfecha, femenina. A veces solicita para sí la atención y ayuda de los otros; es impaciente, dependiente, poco practica. Le disgustan las personas y profesiones rudas. Suele frenar la acción del grupo y alterar su moral con actividades inútiles e idealistas.";
            if (decatype >= 0)
                return "Harria: La persona que puntúa bajo tiende a ser práctica, realista, varonil, independiente, responsable y, a la vez, indiferente de las elaboraciones culturales subjetivas. A veces es inamovible, dura, cínica, orgullosa de sí misma. Tiende a mantener el grupo trabajando sobre unas bases prácticas, realistas y acertadas.";

            return string.Empty;
        }

        private static string Description_FactorL(byte decatype)
        {
            if (decatype >= 5)
                return "Alaxia: La persona que puntúa alto suele ser desconfiada y ambigua. A menudo se encuentra complicada con su propio yo, le gusta opinar sobre sí misma, y se sumerge en sus fantasías (no necesariamente será “paranoia”). Suele actuar con premeditación; es desapegada de los otros y colabora deficientemente con el grupo.";
            if (decatype >= 0)
                return "Protesión: La persona que puntúa bajo suele no presentar tendencia a los celos o envidia; es adaptable, valiente, no competitiva, interesada por los demás, de buena colaboración con el grupo.";

            return string.Empty;
        }

        private static string Description_FactorM(byte decatype)
        {
            if (decatype >= 5)
                return "Praxernia: La persona que puntúa alto tiende a ser poco convencional, despreocupada de lo cotidiano, desorganizada, motivada por sí misma, creadora, imaginativa, preocupada por lo “esencial” y despreocupada de las personas particulares y la realidad física. Sus intereses, dirigidos hacia su intimidad, la llevan a veces a situaciones irreales, con explosiones expresivas. Su individualidad le empuja verse excluido de las actividades del grupo.";
            if (decatype >= 0)
                return "Autia: La persona que puntúa bajo suele mostrarse ansiosa por hacer las cosas correctamente, atenta a los problemas prácticos y sujeta a los dictados de lo que es evidentemente posible. Se preocupa por los detalles, capacidad de permanecer sereno en situaciones de emergencia, aunque a veces es poco imaginativa.";

            return string.Empty;
        }

        private static string Description_FactorN(byte decatype)
        {
            if (decatype >= 5)
                return "Astucia: La persona que puntúa alto suele ser refinada, experimentada, mundana y astuta. A menudo es “cabeza dura” y analítica. Su enfoque es intelectual y poco sentimental, aproximándose a las situaciones de una manera casi cínica.";
            if (decatype >= 0)
                return "Sencillez: La persona que puntúa bajo suele ser sencilla, sentimental, accesible y poco sofisticada. Se le satisface fácilmente y se muestra contenta con lo que le acontece; es natural, espontanea, poco refinada y torpe.";

            return string.Empty;
        }

        private static string Description_FactorO(byte decatype)
        {
            if (decatype >= 5)
                return "Tendencia a la cupabilidad: La persona que puntúa alto suele ser depresiva, preocupada, llena de presagios e ideas largamente gestadas. Ante las dificultades presenta tendencia infantil a la ansiedad. En los grupos no se siente aceptada ni con libertad para actuar. Una puntuación alta es muy corriente en los grupos clínicos de todo tipo.";
            if (decatype >= 0)
                return "Adecuación imperturbable: La persona que puntúa bajo tiende a ser tranquila, de ánimo invariable. Su confianza en sí misma y su capacidad para tratar con cosas es madura y poco ansiosa; es flexible y segura, pero puede mostrarse insensible cuando en el grupo no va de acuerdo con ella, lo cual puede provocar antipatías y recelos.";

            return string.Empty;
        }

        private static string Description_FactorQ1(byte decatype)
        {
            if (decatype >= 5)
                return "Radicalismo: La persona que puntúa alto suele interesarse por cuestiones intelectuales y dudar de los principios fundamentales. Es escéptica y de espíritu inquisitivo en las ideas, sean tradicionales o nuevas. Suele estar bien informada, poco inclinada a moralizar y mas a preguntarse por la vida en general y a ser más tolerante con las molestias y el cambio.";
            if (decatype >= 0)
                return "Conservadurismo: La persona que puntúa bajo tiende a ser tranquila, de ánimo invariable. Su confianza en sí misma y su capacidad para tratar con cosas es madura y poco ansiosa; es flexible y segura, pero puede mostrarse insensible cuando en el grupo no va de acuerdo con ella, lo cual puede provocar antipatías y recelos.";

            return string.Empty;
        }

        private static string Description_FactorQ2(byte decatype)
        {
            if (decatype >= 5)
                return "Autosuficiencia: La persona que puntúa alto es temperamentalmente independiente, acostumbrada a seguir su propio camino; toma sus decisiones y actúa por su propio camino; toma decisiones y actúa por su cuenta. No tiene en consideración la opinión del grupo, aunque no es necesariamente dominante en sus relaciones con los demás. No le disgusta la gente, simplemente no necesita de su asentimiento y apoyo.";
            if (decatype >= 0)
                return "Adhesión al grupo: La persona que puntúa bajo prefiere trabajar y tomar decisiones con los demás, le gusta y depende de la aprobación social. Tiende a seguir las directrices del grupo, incluso mostrando falta de decisiones personales. No es necesariamente petición por decisión propia, sino que necesita del apoyo del grupo.";

            return string.Empty;
        }

        private static string Description_FactorQ3(byte decatype)
        {
            if (decatype >= 5)
                return "Mucho control de su autoimagen: La persona que puntúa alto suele tener mucho control de sus emociones y conducta en general, y ser cuidadosa y abierta a lo social; evidencia lo que comúnmente se llama “respeto hacia sí misma”; tiene en cuenta la reputación social. No obstante, a veces tiende a ser obstinada. Los lideres eficaces y algunos paranoicos puntúan alto en Q3.";
            if (decatype >= 0)
                return "Baja integración: La persona que puntúa bajo no está preocupada por aceptar y ajustarse a las exigencias sociales. No es excesivamente considerada, cuidadosa o esmerada. Puede sentirse desajustada, y a muchas de sus desadaptaciones (especialmente las afectivas, pero no las paranoicas) puntúan en esta dirección de la variable.";

            return string.Empty;
        }

        private static string Description_FactorQ4(byte decatype)
        {
            if (decatype >= 5)
                return "Emociones fuertes: La persona que puntúa alto suele ser tensa, excitable, intranquila, irritable e impaciente. Esta a menudo fatigada, pero incapaz de permanecer inactiva. Dentro del grupo tiene una pobre visión del grado de unión, del orden y del mando. Su frustración representa un exceso del impulso de estimulación no descargada.";
            if (decatype >= 0)
                return "Pocas emociones: La persona que puntúa bajo no está preocupada por aceptar y ajustarse a las exigencias sociales. No es excesivamente considerada, cuidadosa o esmerada. Puede sentirse desajustada, y a muchas de sus desadaptaciones (especialmente las afectivas, pero no las paranoicas) puntúan en esta dirección de la variable.";

            return string.Empty;
        }
    }
}
