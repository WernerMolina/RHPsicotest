using RHPsicotest.WebSite.Tests.Responses;
using System;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.GenerateResults
{
    public class Results_Dominos
    {
        public static byte GetScoreTotal(char?[][] responses)
        {
            byte counter = 0;
            byte scoreTotal = 0;

            int?[,] responsesInByte = new int?[44, 2];

            for (int i = 0; i < 44; i++)
            {
                responsesInByte[i, 0] = responses[i][0] is not null ? Convert.ToByte(responses[i][0].ToString()) : null;
                responsesInByte[i, 1] = responses[i][1] is not null ? Convert.ToByte(responses[i][1].ToString()) : null;
            }

            List<Responses_Dominos> responsesDominos = Responses_Dominos.GetResponses();

            foreach (var response in responsesDominos)
            {
                if (responsesInByte[counter, 0] == null ||
                    responsesInByte[counter, 1] == null) continue;
                else
                {
                    if (responsesInByte[counter, 0] == response.Numerator &&
                        responsesInByte[counter, 1] == response.Denominator) scoreTotal++;
                }

                counter++;
            }

            return scoreTotal;
        }

        public static string GetDescriptionByPercentile(byte percentile)
        {
            string description = string.Empty;

            if (percentile >= 77) description = "Superior: el coeficiente intelectual de la persona se sitúa en la categoría “superior”, por lo que el rendimiento del individuo se puede ver beneficiado al poseer el dominio particular de habilidades necesarias para abordar con éxito ocupaciones con demandas prácticas complejas.";
            if (percentile >= 55) description = "Superior al término medio: la persona evaluada se encuentra en un rango “superior al término medio”. El candidato tiene desarrollada su habilidad de pensamiento lógico arriba del promedio, por lo que tiende a una buena ejecución de tareas abstractas que requieran observación, para extraer de ellas principios y poder aplicarlos.";
            if (percentile == 50) description = "Término medio: la persona evaluada se encuentra en un rango de “término medio” en cuanto a su coeficiente intelectual se puede decir que posee una capacidad promedio dentro de la población. Sus habilidades de procesamiento lógico y razonamiento sistémico son muy significativas para darle solución a diferentes problemáticas.";
            if (percentile >= 25) description = "Inferior al término medio: la persona evaluada se ubica en un rango “inferior al término medio”, sus habilidades para la solución de problemas prácticos se encuentran por debajo del promedio de la población. Esto en algunas situaciones puede presentar una dificultad para razonar de forma conceptual y sistemática.";
            if (percentile >= 1) description = "Deficiente: su coeficiente intelectual se encuentra en el rango “deficiente”, por lo que su capacidad para conceptualizar y aplicar el razonamiento sistemático a nuevos problemas, esto puede afectar negativamente en el desempeño del evaluado ante situaciones que ameriten la resolución de problemas prácticos.";

            return description;
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
                    percentile = Percentile_ProfesionalPublicidad(score);
                    break;
                case "Técnico Medios Industriales":
                    percentile = Percentile_Tecnico_Industrial(score);
                    break;
                case "Técnico Comercial":
                    percentile = Percentile_TecnicoComercial(score);
                    break;
                case "Inspector o Delegado":
                    percentile = Percentile_JefeVigilancia(score);
                    break;
                case "Agente de Venta":
                    percentile = Percentile_AgenteComercial(score);
                    break;
                case "Jefe Administrativo":
                    percentile = Percentile_JefeAdministrativo(score);
                    break;
                case "Jefe Administrativo Oficial o Auxiliar":
                    percentile = Percentile_Administrativo(score);
                    break;
                case "Analista Programador":
                    percentile = Percentile_ProgramadorAnalista(score);
                    break;
                case "Técnico de Organización":
                    percentile = Percentile_TecnicoEnMetodo(score);
                    break;
                case "Monitor o Mando Medios":
                    percentile = Percentile_Jefatura(score);
                    break;
                case "Operario Mecánico":
                    percentile = Percentile_OperarioMecanico(score);
                    break;
                case "Secretaria":
                    percentile = Percentile_Secretaria(score);
                    break;
                case "Administrativa":
                    percentile = Percentile_AsistenteAdministrativa(score);
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
            if (score >= 37) return 90;
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
            if (score >= 23) return 20;
            if (score == 22) return 15;
            if (score == 21) return 11;
            if (score >= 17) return 10;
            if (score == 16) return 5;
            if (score >= 11) return 4;
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
            if (score >= 25) return 10;
            if (score == 24) return 5;
            if (score >= 20) return 4;
            if (score <= 19) return 1;

            return 0;
        }

        private static byte Percentile_Licenciado(byte score)
        {
            if (score >= 43) return 99;
            if (score == 42) return 97;
            if (score == 41) return 96;
            if (score == 40) return 95;
            if (score >= 38) return 90;
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
            if (score >= 23) return 15;
            if (score == 22) return 11;
            if (score >= 19) return 10;
            if (score == 18) return 5;
            if (score >= 14) return 4;
            if (score <= 13) return 1;

            return 0;
        }

        private static byte Percentile_ProfesionalPublicidad(byte score)
        {
            if (score >= 43) return 99;
            if (score == 41) return 97;
            if (score == 40) return 96;
            if (score == 39) return 95;
            if (score >= 37) return 90;
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
            if (score >= 19) return 10;
            if (score == 18) return 5;
            if (score >= 9) return 4;
            if (score <= 8) return 1;

            return 0;
        }

        private static byte Percentile_Tecnico_Industrial(byte score)
        {
            if (score >= 43) return 99;
            if (score == 40) return 97;
            if (score == 39) return 96;
            if (score == 38) return 95;
            if (score >= 36) return 90;
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
            if (score >= 20) return 10;
            if (score == 19) return 5;
            if (score >= 16) return 4;
            if (score <= 15) return 1;

            return 0;
        }

        private static byte Percentile_TecnicoComercial(byte score)
        {
            if (score >= 43) return 99;
            if (score == 41) return 97;
            if (score == 40) return 96;
            if (score == 39) return 95;
            if (score >= 36) return 90;
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
            if (score >= 20) return 15;
            if (score == 19) return 11;
            if (score >= 17) return 10;
            if (score == 16) return 5;
            if (score >= 12) return 4;
            if (score <= 11) return 1;

            return 0;
        }

        // Error 0-16
        private static byte Percentile_JefeVigilancia(byte score)
        {
            if (score >= 40) return 99;
            if (score >= 38) return 97;
            if (score == 37) return 96;
            if (score == 36) return 95;
            if (score >= 34) return 90;
            if (score == 33) return 89;
            if (score == 32) return 85;
            if (score == 31) return 80;
            if (score == 30) return 75;
            if (score == 29) return 70;
            if (score == 28) return 65;
            if (score == 27) return 60;
            if (score == 26) return 55;
            if (score == 25) return 50;
            if (score == 24) return 45;
            if (score == 23) return 40;
            if (score == 22) return 35;
            if (score == 21) return 30;
            if (score == 20) return 25;
            if (score >= 18) return 20;
            if (score == 17) return 15;
            if (score == 16) return 11;
            if (score >= 14) return 10;
            if (score == 13) return 5;
            if (score == 12) return 4;
            if (score <= 11) return 1;

            return 0;
        }

        private static byte Percentile_AgenteComercial(byte score)
        {
            if (score >= 38) return 99;
            if (score >= 36) return 97;
            if (score == 35) return 95;
            if (score >= 32) return 90;
            if (score == 31) return 85;
            if (score >= 29) return 80;
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
            if (score >= 15) return 15;
            if (score == 14) return 11;
            if (score >= 11) return 10;
            if (score >= 9) return 5;
            if (score >= 3) return 4;
            if (score <= 2) return 1;

            return 0;
        }

        private static byte Percentile_JefeAdministrativo(byte score)
        {
            if (score >= 41) return 99;
            if (score >= 39) return 97;
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
            if (score >= 19) return 15;
            if (score == 18) return 11;
            if (score >= 16) return 10;
            if (score == 15) return 5;
            if (score >= 11) return 4;
            if (score <= 10) return 1;

            return 0;
        }

        private static byte Percentile_Administrativo(byte score)
        {
            if (score >= 41) return 99;
            if (score >= 39) return 97;
            if (score == 38) return 96;
            if (score == 37) return 95;
            if (score >= 34) return 90;
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
            if (score >= 14) return 10;
            if (score == 13) return 5;
            if (score >= 8) return 4;
            if (score <= 7) return 1;

            return 0;
        }

        private static byte Percentile_ProgramadorAnalista(byte score)
        {
            if (score >= 40) return 99;
            if (score >= 38) return 97;
            if (score == 37) return 95;
            if (score >= 35) return 90;
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
            if (score >= 20) return 15;
            if (score == 19) return 11;
            if (score >= 16) return 10;
            if (score == 15) return 5;
            if (score >= 12) return 4;
            if (score <= 11) return 1;

            return 0;
        }

        private static byte Percentile_TecnicoEnMetodo(byte score)
        {
            if (score >= 38) return 99;
            if (score >= 35) return 97;
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
            if (score >= 19) return 20;
            if (score == 18) return 15;
            if (score == 17) return 11;
            if (score >= 15) return 10;
            if (score == 14) return 5;
            if (score >= 6) return 4;
            if (score <= 5) return 1;

            return 0;
        }

        private static byte Percentile_Jefatura(byte score)
        {
            if (score >= 37) return 99;
            if (score >= 35) return 97;
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
            if (score >= 14) return 10;
            if (score == 13) return 5;
            if (score >= 6) return 4;
            if (score <= 5) return 1;

            return 0;
        }

        private static byte Percentile_OperarioMecanico(byte score)
        {
            if (score >= 37) return 99;
            if (score >= 35) return 97;
            if (score == 34) return 96;
            if (score == 33) return 95;
            if (score >= 31) return 90;
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
            if (score >= 12) return 10;
            if (score == 11) return 5;
            if (score >= 7) return 4;
            if (score <= 6) return 1;

            return 0;
        }

        private static byte Percentile_Secretaria(byte score)
        {
            if (score >= 39) return 99;
            if (score >= 36) return 97;
            if (score == 35) return 96;
            if (score == 34) return 95;
            if (score >= 32) return 90;
            if (score == 31) return 85;
            if (score == 30) return 80;
            if (score == 29) return 70;
            if (score == 28) return 65;
            if (score == 27) return 60;
            if (score == 26) return 50;
            if (score == 25) return 45;
            if (score == 24) return 40;
            if (score >= 22) return 30;
            if (score == 21) return 25;
            if (score == 20) return 23;
            if (score == 19) return 20;
            if (score >= 17) return 15;
            if (score == 16) return 11;
            if (score >= 13) return 10;
            if (score == 12) return 5;
            if (score >= 8) return 4;
            if (score <= 7) return 1;

            return 0;
        }

        private static byte Percentile_AsistenteAdministrativa(byte score)
        {
            if (score >= 37) return 99;
            if (score >= 35) return 97;
            if (score == 34) return 96;
            if (score == 33) return 95;
            if (score >= 31) return 90;
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
            if (score >= 15) return 20;
            if (score == 14) return 15;
            if (score == 13) return 11;
            if (score >= 10) return 10;
            if (score == 9) return 5;
            if (score >= 3) return 4;
            if (score <= 2) return 1;

            return 0;
        }
    }
}
