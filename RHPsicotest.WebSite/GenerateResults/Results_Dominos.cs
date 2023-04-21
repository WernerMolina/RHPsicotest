using RHPsicotest.WebSite.Tests.Responses;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.GenerateResults
{
    public class Results_Dominos
    {
        public static byte GetScoreTotal(byte?[,] candidateResponses)
        {
            byte scoreTotal = 0;

            List<Responses_Dominos> responsesDominos = Responses_Dominos.GetResponses();

            byte counter = 0;

            foreach (var response in responsesDominos)
            {
                if (candidateResponses[counter, 0] == null ||
                    candidateResponses[counter, 1] == null) continue;
                else
                {
                    if (candidateResponses[counter, 0] == response.Numerator &&
                        candidateResponses[counter, 1] == response.Denominator) scoreTotal++;
                }

                counter++;
            }

            return scoreTotal;
        }

        public static byte GetPercentileByScore(byte score, string academicTraining)
        {
            byte percentile = 0;

            switch (academicTraining)
            {
                case "Directivo":
                    percentile = Percentile_Directivo(score);
                    break;
                case "Ingeniero":
                    percentile = Percentile_Ingeniero(score);
                    break;
                case "Licenciado":
                    percentile = Percentile_Licenciado(score);
                    break;
                case "Profesional":
                    percentile = Percentile_Profesional(score);
                    break;
                case "Técnico Medios Industriales":
                    percentile = Percentile_Tecnico(score);
                    break;
                case "Técnico Comercial":
                    percentile = Percentile_TecnicoComercial(score);
                    break;
                case "Inspector o Delegado":
                    percentile = Percentile_InspectorYDelegado(score);
                    break;
                case "Agente de Venta":
                    percentile = Percentile_AgenteDeVenta(score);
                    break;
                case "Jefe Administrativo":
                    percentile = Percentile_JefeAdministrativo(score);
                    break;
                case "Jefe Administrativo Oficial o Auxiliar":
                    percentile = Percentile_AdministrativoOficialYAuxilizar(score);
                    break;
                case "Analista Programador":
                    percentile = Percentile_ProgramadorAnalista(score);
                    break;
                case "Técnico de Organización":
                    percentile = Percentile_TecnicoDeOrganizacion(score);
                    break;
                case "Monitor o Mando Medios":
                    percentile = Percentile_MonitorYMandosMedios(score);
                    break;
                case "Operario Mecánico":
                    percentile = Percentile_OperarioMecanico(score);
                    break;
                case "Secretaria":
                    percentile = Percentile_Secretaria(score);
                    break;
                case "Administrativa":
                    percentile = Percentile_Administrativa(score);
                    break;
                default:
                    percentile = 0;
                    break;
            }

            return percentile;
        }

        private static byte Percentile_Directivo(byte score)
        {
            if (score >= 42) return 99;
            if (score == 41) return 97;
            if (score == 40) return 96;
            if (score == 39) return 95;
            if (score == 37) return 90;
            if (score == 36) return 89;
            if (score == 35) return 85;
            if (score == 34) return 80;
            if (score == 33) return 75;
            if (score == 32) return 65;
            if (score == 31) return 60;
            if (score == 30) return 50;
            if (score == 29) return 45;
            if (score == 28) return 40;
            if (score == 27) return 35;
            if (score == 26) return 30;
            if (score == 25) return 23;
            if (score == 24) return 20;
            if (score == 22) return 15;
            if (score == 21) return 11;
            if (score == 20) return 10;
            if (score == 16) return 5;
            if (score == 15) return 4;
            if (score <= 10) return 1;

            return 0;
        }

        private static byte Percentile_Ingeniero(byte score)
        {
            if (score == 44) return 99;
            if (score == 43) return 97;
            if (score == 42) return 95;
            if (score == 41) return 90;
            if (score == 40) return 89;
            if (score == 39) return 85;
            if (score == 38) return 80;
            if (score == 37) return 75;
            if (score == 36) return 70;
            if (score == 35) return 65;
            if (score == 34) return 55;
            if (score == 33) return 50;
            if (score == 32) return 40;
            if (score == 31) return 30;
            if (score == 30) return 23;
            if (score == 29) return 20;
            if (score == 28) return 15;
            if (score == 27) return 11;
            if (score == 26) return 10;
            if (score == 24) return 5;
            if (score == 23) return 4;
            if (score <= 19) return 1;

            return 0;
        }

        private static byte Percentile_Licenciado(byte score)
        {
            if (score >= 43) return 99;
            if (score == 42) return 97;
            if (score == 41) return 96;
            if (score == 40) return 95;
            if (score == 38) return 90;
            if (score == 37) return 89;
            if (score == 36) return 85;
            if (score == 35) return 80;
            if (score == 34) return 77;
            if (score == 33) return 75;
            if (score == 32) return 65;
            if (score == 31) return 60;
            if (score == 30) return 50;
            if (score == 29) return 45;
            if (score == 28) return 35;
            if (score == 27) return 30;
            if (score == 26) return 25;
            if (score == 25) return 20;
            if (score == 24) return 15;
            if (score == 22) return 11;
            if (score == 21) return 10;
            if (score == 18) return 5;
            if (score == 17) return 4;
            if (score <= 13) return 1;

            return 0;
        }

        private static byte Percentile_Profesional(byte score)
        {
            if (score >= 43) return 99;
            if (score == 41) return 97;
            if (score == 40) return 96;
            if (score == 39) return 95;
            if (score == 37) return 90;
            if (score == 36) return 89;
            if (score == 35) return 85;
            if (score == 34) return 80;
            if (score == 33) return 75;
            if (score == 32) return 70;
            if (score == 31) return 65;
            if (score == 30) return 60;
            if (score == 29) return 55;
            if (score == 28) return 50;
            if (score == 27) return 40;
            if (score == 26) return 35;
            if (score == 25) return 30;
            if (score == 24) return 25;
            if (score == 23) return 23;
            if (score == 22) return 20;
            if (score == 21) return 15;
            if (score == 20) return 10;
            if (score == 18) return 5;
            if (score == 17) return 4;
            if (score <= 8) return 1;

            return 0;
        }

        private static byte Percentile_Tecnico(byte score)
        {
            if (score >= 43) return 99;
            if (score == 40) return 97;
            if (score == 39) return 96;
            if (score == 38) return 95;
            if (score == 36) return 90;
            if (score == 35) return 85;
            if (score == 34) return 80;
            if (score == 33) return 77;
            if (score == 32) return 70;
            if (score == 31) return 65;
            if (score == 30) return 55;
            if (score == 29) return 50;
            if (score == 28) return 40;
            if (score == 27) return 30;
            if (score == 26) return 25;
            if (score == 25) return 20;
            if (score == 24) return 15;
            if (score == 23) return 11;
            if (score == 22) return 10;
            if (score == 19) return 5;
            if (score == 18) return 4;
            if (score <= 15) return 1;

            return 0;
        }

        private static byte Percentile_TecnicoComercial(byte score)
        {
            if (score >= 43) return 99;
            if (score == 41) return 97;
            if (score == 40) return 96;
            if (score == 39) return 95;
            if (score == 36) return 90;
            if (score == 35) return 89;
            if (score == 34) return 85;
            if (score == 33) return 80;
            if (score == 32) return 75;
            if (score == 31) return 70;
            if (score == 30) return 65;
            if (score == 29) return 60;
            if (score == 28) return 55;
            if (score == 27) return 50;
            if (score == 26) return 40;
            if (score == 25) return 35;
            if (score == 24) return 30;
            if (score == 23) return 25;
            if (score == 22) return 20;
            if (score == 21) return 15;
            if (score == 19) return 11;
            if (score == 18) return 10;
            if (score == 16) return 5;
            if (score == 15) return 4;
            if (score <= 11) return 1;

            return 0;
        }

        // Error 0-16
        private static byte Percentile_InspectorYDelegado(byte score)
        {
            if (score >= 40) return 99;
            if (score == 38) return 97;
            if (score == 37) return 96;
            if (score == 36) return 95;
            if (score == 34) return 90;
            if (score == 33) return 89;
            if (score == 32) return 85;
            if (score == 31) return 75;
            if (score == 30) return 70;
            if (score == 29) return 65;
            if (score == 28) return 60;
            if (score == 27) return 55;
            if (score == 26) return 50;
            if (score == 25) return 45;
            if (score == 24) return 40;
            if (score == 23) return 35;
            if (score == 22) return 30;
            if (score == 21) return 25;
            if (score == 20) return 20;
            if (score == 19) return 15;
            if (score == 17) return 11;
            if (score == 16) return 10;
            if (score == 15) return 5;
            if (score == 13) return 4;
            if (score == 12) return 4;
            if (score <= 11) return 1;

            return 0;
        }

        private static byte Percentile_AgenteDeVenta(byte score)
        {
            if (score >= 38) return 99;
            if (score == 36) return 97;
            if (score == 35) return 95;
            if (score == 32) return 90;
            if (score == 31) return 85;
            if (score == 29) return 80;
            if (score == 28) return 75;
            if (score == 27) return 70;
            if (score == 26) return 65;
            if (score == 25) return 60;
            if (score == 24) return 55;
            if (score == 23) return 50;
            if (score == 22) return 40;
            if (score == 21) return 35;
            if (score == 20) return 30;
            if (score == 19) return 25;
            if (score == 18) return 23;
            if (score == 17) return 20;
            if (score == 16) return 15;
            if (score == 14) return 11;
            if (score == 13) return 10;
            if (score >= 9) return 5;
            if (score == 8) return 4;
            if (score <= 2) return 1;

            return 0;
        }

        private static byte Percentile_JefeAdministrativo(byte score)
        {
            if (score >= 41) return 99;
            if (score == 39) return 97;
            if (score == 38) return 96;
            if (score == 37) return 95;
            if (score == 36) return 90;
            if (score == 35) return 89;
            if (score == 34) return 85;
            if (score == 33) return 80;
            if (score == 32) return 77;
            if (score == 31) return 75;
            if (score == 30) return 70;
            if (score == 29) return 60;
            if (score == 28) return 55;
            if (score == 27) return 50;
            if (score == 26) return 45;
            if (score == 25) return 40;
            if (score == 24) return 35;
            if (score == 23) return 30;
            if (score == 22) return 23;
            if (score == 21) return 20;
            if (score == 20) return 15;
            if (score == 18) return 11;
            if (score == 17) return 10;
            if (score == 15) return 5;
            if (score == 14) return 4;
            if (score <= 10) return 1;

            return 0;
        }

        private static byte Percentile_AdministrativoOficialYAuxilizar(byte score)
        {
            if (score >= 41) return 99;
            if (score == 39) return 97;
            if (score == 38) return 96;
            if (score == 37) return 95;
            if (score == 34) return 90;
            if (score == 33) return 85;
            if (score == 32) return 80;
            if (score == 31) return 77;
            if (score == 30) return 70;
            if (score == 29) return 65;
            if (score == 28) return 60;
            if (score == 27) return 55;
            if (score == 26) return 50;
            if (score == 25) return 45;
            if (score == 24) return 40;
            if (score == 23) return 35;
            if (score == 22) return 25;
            if (score == 21) return 23;
            if (score == 20) return 20;
            if (score == 19) return 15;
            if (score == 18) return 11;
            if (score == 17) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score <= 7) return 1;

            return 0;
        }

        private static byte Percentile_ProgramadorAnalista(byte score)
        {
            if (score >= 40) return 99;
            if (score == 38) return 97;
            if (score == 37) return 95;
            if (score == 35) return 90;
            if (score == 34) return 89;
            if (score == 33) return 80;
            if (score == 32) return 77;
            if (score == 31) return 70;
            if (score == 30) return 65;
            if (score == 29) return 60;
            if (score == 28) return 55;
            if (score == 27) return 50;
            if (score == 26) return 40;
            if (score == 25) return 35;
            if (score == 24) return 30;
            if (score == 23) return 23;
            if (score == 22) return 20;
            if (score == 21) return 15;
            if (score == 19) return 11;
            if (score == 18) return 10;
            if (score == 15) return 5;
            if (score == 14) return 4;
            if (score <= 11) return 1;

            return 0;
        }

        private static byte Percentile_TecnicoDeOrganizacion(byte score)
        {
            if (score >= 38) return 99;
            if (score == 35) return 97;
            if (score == 34) return 95;
            if (score == 33) return 90;
            if (score == 32) return 85;
            if (score == 31) return 80;
            if (score == 30) return 75;
            if (score == 29) return 70;
            if (score == 28) return 60;
            if (score == 27) return 55;
            if (score == 26) return 50;
            if (score == 25) return 40;
            if (score == 24) return 35;
            if (score == 23) return 30;
            if (score == 22) return 25;
            if (score == 21) return 23;
            if (score == 20) return 20;
            if (score == 18) return 15;
            if (score == 17) return 11;
            if (score == 16) return 10;
            if (score == 14) return 5;
            if (score == 13) return 4;
            if (score <= 5) return 1;

            return 0;
        }

        private static byte Percentile_MonitorYMandosMedios(byte score)
        {
            if (score >= 37) return 99;
            if (score == 35) return 97;
            if (score == 34) return 96;
            if (score == 33) return 95;
            if (score == 32) return 90;
            if (score == 31) return 89;
            if (score == 30) return 85;
            if (score == 29) return 80;
            if (score == 28) return 75;
            if (score == 27) return 65;
            if (score == 26) return 60;
            if (score == 25) return 55;
            if (score == 24) return 50;
            if (score == 23) return 40;
            if (score == 22) return 35;
            if (score == 21) return 30;
            if (score == 20) return 23;
            if (score == 19) return 20;
            if (score == 18) return 15;
            if (score == 17) return 11;
            if (score == 16) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score <= 5) return 1;

            return 0;
        }

        private static byte Percentile_OperarioMecanico(byte score)
        {
            if (score >= 37) return 99;
            if (score == 35) return 97;
            if (score == 34) return 96;
            if (score == 33) return 95;
            if (score == 31) return 90;
            if (score == 30) return 89;
            if (score == 29) return 85;
            if (score == 28) return 80;
            if (score == 27) return 70;
            if (score == 26) return 65;
            if (score == 25) return 60;
            if (score == 24) return 55;
            if (score == 23) return 50;
            if (score == 22) return 45;
            if (score == 21) return 40;
            if (score == 20) return 35;
            if (score == 19) return 30;
            if (score == 18) return 25;
            if (score == 17) return 23;
            if (score == 16) return 20;
            if (score == 15) return 15;
            if (score == 14) return 11;
            if (score == 13) return 10;
            if (score == 11) return 5;
            if (score == 10) return 4;
            if (score <= 6) return 1;

            return 0;
        }

        private static byte Percentile_Secretaria(byte score)
        {
            if (score >= 39) return 99;
            if (score == 36) return 97;
            if (score == 35) return 96;
            if (score == 34) return 95;
            if (score == 32) return 90;
            if (score == 31) return 85;
            if (score == 30) return 80;
            if (score == 29) return 70;
            if (score == 28) return 65;
            if (score == 27) return 60;
            if (score == 26) return 50;
            if (score == 25) return 45;
            if (score == 24) return 40;
            if (score == 23) return 30;
            if (score == 21) return 25;
            if (score == 20) return 23;
            if (score == 19) return 20;
            if (score == 18) return 15;
            if (score == 16) return 11;
            if (score == 15) return 10;
            if (score == 12) return 5;
            if (score == 11) return 4;
            if (score <= 7) return 1;

            return 0;
        }

        private static byte Percentile_Administrativa(byte score)
        {
            if (score >= 37) return 99;
            if (score == 35) return 97;
            if (score == 34) return 96;
            if (score == 33) return 95;
            if (score == 31) return 90;
            if (score == 30) return 85;
            if (score == 29) return 80;
            if (score == 28) return 75;
            if (score == 27) return 70;
            if (score == 26) return 65;
            if (score == 25) return 60;
            if (score == 24) return 55;
            if (score == 23) return 50;
            if (score == 22) return 45;
            if (score == 21) return 40;
            if (score == 20) return 35;
            if (score == 19) return 30;
            if (score == 18) return 25;
            if (score == 17) return 23;
            if (score == 16) return 20;
            if (score == 14) return 15;
            if (score == 13) return 11;
            if (score == 12) return 10;
            if (score == 9) return 5;
            if (score == 8) return 4;
            if (score <= 2) return 1;

            return 0;
        }
    }
}
