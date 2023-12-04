using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RHPsicotest.WebSite.Tests.Responses;

namespace RHPsicotest.WebSite.GenerateResults
{
    public class Results_IPV
    {
        public static byte[] GetScoresByFactor(char[] responsesCandidate)
        {
            byte[] scoresByFactor = new byte[12];

            for (byte i = 0; i < 12; i++)
            {
                if (i == 1 || i == 2) continue;

                List<Responses_IPV> responses_IPV = Responses_IPV.GetResponses().Where(r => r.IdFactor == i + 1).ToList();

                foreach (Responses_IPV response in responses_IPV)
                {
                    if (responsesCandidate[--response.QuestionNumber] == response.Correct) scoresByFactor[i]++;
                }
            }

            scoresByFactor[6] = Convert.ToByte(8 - scoresByFactor[6]);

            // Receptividad = I -> IV
            for (byte i = 3; i <= 6; i++)
            {
                scoresByFactor[1] += scoresByFactor[i];
            }
            
            // Agresividad = V -> IX 
            for (byte i = 7; i <= 10; i++)
            {
                scoresByFactor[2] += scoresByFactor[i];
            }

            return scoresByFactor;
        }

        public static byte[] GetDecatypesByFactor(byte[] scoresByFactor)
        {
            byte[] decatypes = new byte[12];

            decatypes[0] = GetDecatype_FactorDGV(scoresByFactor[0]);
            decatypes[1] = GetDecatype_FactorR(scoresByFactor[1]);
            decatypes[2] = GetDecatype_FactorA(scoresByFactor[2]);
            decatypes[3] = GetDecatype_FactorI(scoresByFactor[3]);
            decatypes[4] = GetDecatype_FactorII(scoresByFactor[4]);
            decatypes[5] = GetDecatype_FactorIII(scoresByFactor[5]);
            decatypes[6] = GetDecatype_FactorIV(scoresByFactor[6]);
            decatypes[7] = GetDecatype_FactorV(scoresByFactor[7]);
            decatypes[8] = GetDecatype_FactorVI(scoresByFactor[8]);
            decatypes[9] = GetDecatype_FactorVII(scoresByFactor[9]);
            decatypes[10] = GetDecatype_FactorVIII(scoresByFactor[10]);
            decatypes[11] = GetDecatype_FactorIX(scoresByFactor[11]);
            return decatypes;
        }

        public static string[] GetDescriptionsByFactor(byte[] decatypesByFactor)
        {
            string[] descriptions = new string[12];

            descriptions[0] = GetDescription_FactorDGV(decatypesByFactor[0]);
            descriptions[1] = GetDescription_FactorR(decatypesByFactor[1]);
            descriptions[2] = GetDescription_FactorA(decatypesByFactor[2]);
            descriptions[3] = GetDescription_FactorI(decatypesByFactor[3]);
            descriptions[4] = GetDescription_FactorII(decatypesByFactor[4]);
            descriptions[5] = GetDescription_FactorIII(decatypesByFactor[5]);
            descriptions[6] = GetDescription_FactorIV(decatypesByFactor[6]);
            descriptions[7] = GetDescription_FactorV(decatypesByFactor[7]);
            descriptions[8] = GetDescription_FactorVI(decatypesByFactor[8]);
            descriptions[9] = GetDescription_FactorVII(decatypesByFactor[9]);
            descriptions[10] = GetDescription_FactorVIII(decatypesByFactor[10]);
            descriptions[11] = GetDescription_FactorIX(decatypesByFactor[11]);

            return descriptions;
        }

        // Tabla de Baremos para obtener el Decatipo
        private static byte GetDecatype_FactorDGV(byte score)
        {
            if (score >= 16) return 10;
            if (score == 15) return 9;
            if (score >= 13) return 8;
            if (score == 12) return 7;
            if (score == 11) return 6;
            if (score == 10) return 5;
            if (score == 9) return 4;
            if (score >= 7) return 3;
            if (score == 6) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorR(byte score)
        {
            if (score >= 29) return 10;
            if (score >= 27) return 9;
            if (score >= 25) return 8;
            if (score >= 23) return 7;
            if (score >= 21) return 6;
            if (score == 20) return 5;
            if (score >= 18) return 4;
            if (score >= 16) return 3;
            if (score == 15) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorA(byte score)
        {
            if (score >= 21) return 10;
            if (score >= 19) return 9;
            if (score >= 17) return 8;
            if (score == 16) return 7;
            if (score >= 14) return 6;
            if (score == 13) return 5;
            if (score >= 11) return 4;
            if (score >= 9) return 3;
            if (score == 8) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorI(byte score)
        {
            if (score >= 9) return 10;
            if (score == 8) return 9;
            if (score == 7) return 8;
            if (score == 6) return 7;
            if (score == 5) return 6;
            if (score == 4) return 4;
            if (score == 3) return 3;
            if (score == 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorII(byte score)
        {
            if (score >= 9) return 10;
            if (score == 8) return 9;
            if (score == 7) return 8;
            if (score == 6) return 7;
            if (score == 5) return 6;
            if (score == 4) return 4;
            if (score == 3) return 3;
            if (score == 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorIII(byte score)
        {
            if (score >= 9) return 10;
            if (score == 8) return 9;
            if (score == 7) return 8;
            if (score == 6) return 6;
            if (score == 5) return 5;
            if (score == 4) return 4;
            if (score == 3) return 3;
            if (score == 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorIV(byte score)
        {
            if (score == 8) return 9;
            if (score == 7) return 7;
            if (score == 6) return 5;
            if (score == 5) return 4;
            if (score == 4) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorV(byte score)
        {
            if (score >= 9) return 10;
            if (score == 8) return 9;
            if (score == 7) return 8;
            if (score == 6) return 7;
            if (score == 5) return 5;
            if (score == 4) return 4;
            if (score == 3) return 3;
            if (score == 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorVI(byte score)
        {
            if (score >= 7) return 10;
            if (score == 6) return 8;
            if (score == 5) return 7;
            if (score == 4) return 6;
            if (score == 3) return 4;
            if (score == 2) return 3;
            if (score == 1) return 2;
            if (score == 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorVII(byte score)
        {
            if (score >= 6) return 10;
            if (score == 5) return 8;
            if (score == 4) return 7;
            if (score == 3) return 5;
            if (score == 2) return 4;
            if (score == 1) return 2;
            if (score == 0) return 1;

            return 0;
        }

        private static byte GetDecatype_FactorVIII(byte score)
        {
            if (score >= 5) return 10;
            if (score == 4) return 9;
            if (score == 3) return 8;
            if (score == 2) return 6;
            if (score == 1) return 4;
            if (score == 0) return 2;

            return 0;
        }

        private static byte GetDecatype_FactorIX(byte score)
        {
            if (score == 8) return 10;
            if (score == 7) return 9;
            if (score == 6) return 7;
            if (score == 5) return 6;
            if (score == 4) return 4;
            if (score == 3) return 3;
            if (score == 2) return 2;
            if (score >= 0) return 1;

            return 0;
        }

        // Descripciones
        private static string GetDescription_FactorDGV(byte decatype)
        {
            if (decatype >= 7) return "Alto: Señala a una persona que posee una gran capacidad para establecer relaciones con los demás, muestra combatividad y bastante control de sí mismo que le permite persuadir al cliente. En sí, cuenta con rasgos de personalidad acordes a actividades comerciales.";
            if (decatype >= 5) return "Promedio: La persona tiene un espíritu de combatividad que le ayudara a subir las ventas y a persuadir al cliente. Con la adecuada formación y motivación puede llegar a desarrollar habilidades y convertirse en una persona dotada para el área comercial.";
            if (decatype >= 1) return "Bajo: La persona no muestra la destreza de combatividad para poder elevar las ventas, enfrentar los retos y desacuerdos que puedan surgir en el proceso.  No cuenta con las características idóneas para el área de ventas.";

            return string.Empty;
        }

        private static string GetDescription_FactorR(byte decatype)
        {
            if (decatype >= 7) return "Alto: El índice de receptividad por arriba del promedio, muestra a una persona con gran capacidad de empatía, que sabe escuchar y comprender, que se adapta fácilmente a personas y circunstancias y que posee control de sí mismo y resistencia a la frustración.";
            if (decatype >= 5) return "Promedio: Es una persona que sabe ponerse en lugar de los demás, sabe escuchar y comprender, cuenta con capacidad de adaptación a personas y circunstancias, posee control de sí mismo y resistencia a la frustración.";
            if (decatype >= 1) return "Bajo: Es una persona que está por desarrollar la competencia para ponerse en lugar de los demás, sabe escuchar y comprender, así mismo con capacidad de adaptación a personas y circunstancias, posee control de sí mismo y resistencia a la frustración.";

            return string.Empty;
        }

        private static string GetDescription_FactorA(byte decatype)
        {
            if (decatype >= 7) return "Alto: Posee la capacidad para enfrentar situaciones conflictivas o para poder utilizarlas a su favor con el propósito de sacar lo mejor de la situación.  Este tipo de perfil corresponde al tipo agresivo de ventas, como apertura de mercados, acción competitiva hacia otros clientes, etc.";
            if (decatype >= 5) return "Promedio: Es una persona que muestra un índice de agresividad comercial al promedio de la mayoría de la gente, es decir, es un tanto activo y dinámico, cuenta con cierta capacidad para soportar situaciones conflictivas, tiene una actitud de poder o ascendencia suficiente para dominar, intenta estar seguro de sí y puede ser capaz de enfrentar riesgos en casos necesarios.";
            if (decatype >= 1) return "Bajo: El nivel de agresividad que se encuentra es deficiente, mantienen una actitud pasiva lo cual no favorece en el área de las ventas; asimismo no presenta una fuerte capacidad de combatividad en relación a otros clientes.";

            return string.Empty;
        }

        private static string GetDescription_FactorI(byte decatype)
        {
            if (decatype >= 7) return "Alto: La persona presenta altos niveles de empatía, por lo que puede mantener buenas relaciones con los demás. Es objetivo en sus relaciones interpersonales y es capaz de integrar diferentes sucesos a su contexto.";
            if (decatype >= 5) return "Promedio: El índice de comprensión está a nivel promedio, por tanto, se puede decir que es empático y objetivo en sus relaciones humanas, intuitivo e integrador.";
            if (decatype >= 1) return "Bajo: La persona presenta poca empatía hacia las personas que la rodean, por lo que se le dificultan las relaciones interpersonales. No tiene la capacidad de conectar con otros, se centra más en sí mismo y no tienen una buena percepción de las personas y/o contextos que la rodea.";

            return string.Empty;
        }

        private static string GetDescription_FactorII(byte decatype)
        {
            if (decatype >= 7) return "Alto: La persona presenta una gran capacidad para poder adaptarse, tiene facilidad de incorporarse a diferentes contextos y a grupos sociales con éxito. Se muestra flexible en sus actividades, y es capaz de desempeñar sus actividades de una manera eficiente.";
            if (decatype >= 5) return "Promedio: Cuenta con una habilidad promedio para adaptarse fácil y rápidamente a situaciones y personas diferentes, es flexible en sus actividades tanto intelectuales como de relación.";
            if (decatype >= 1) return "Bajo: La persona no presenta una fácil adaptación a situaciones y personas diferentes, es rígida en cuanto a su forma de actuar y de relacionarse con las demás personas.";

            return string.Empty;
        }

        private static string GetDescription_FactorIII(byte decatype)
        {
            if (decatype >= 7) return "Alto: Es una persona controlada, hábil para ocultar sus sentimientos. Capaz de una buena administración de su potencial psicológico o físico, es una persona metódica y perseverante al realizar sus actividades, buscando siempre el cumplimiento de metas.";
            if (decatype >= 5) return "Promedio: Es un individuo que demuestra un control promedio en sus pensamientos y actitudes, es una persona organizada y capaz de administrar su tiempo y recursos para el cumplimento de metas.";
            if (decatype >= 1) return "Bajo: El individuo evaluado demuestra una falta de capacidad de poder controlar los impulsos conductuales y emociones. No presenta un buen manejo sobre la frustración por lo que pierde el enfoque, lo cual no favorece en el área del comercio.";

            return string.Empty;
        }

        private static string GetDescription_FactorIV(byte decatype)
        {
            if (decatype >= 7) return "Alto: Se muestra tolerante al fracaso, tiene un buen domino de la frustración y es capaz de no personalizar las situaciones en las que pueda verse involucrado. Tiene una buena capacidad de enfoque lo que le permite el cumplimiento de metas a corto y largo plazo.";
            if (decatype >= 5) return "Promedio: El individuo posee una capacidad promedio de sobrellevar las situaciones frustrantes, y es capaz de manejar las situaciones en contextos no muy favorables.";
            if (decatype >= 1) return "Bajo: Es una persona que le cuesta sobrellevar adecuadamente las acciones frustrantes, capaz de comprender los fracasos y de no personalizar las situaciones en que se ve implicado.";

            return string.Empty;
        }

        private static string GetDescription_FactorV(byte decatype)
        {
            if (decatype >= 7) return "Alto: Presenta características de un buen vendedor. Tiene capacidad de manejar el conflicto y aceptar los desacuerdos. No tiene tendencia al conformismo y ni a la resignación.";
            if (decatype >= 5) return "Promedio: Es una persona capaz de entrar en conflictos y soportar los desacuerdos, posee agresividad comercial.";
            if (decatype >= 1) return "Bajo: El individuo tiene una actitud pasiva, se le dificulta el manejo de las situaciones que están relacionadas con el conflicto, no posee agresividad.";

            return string.Empty;
        }

        private static string GetDescription_FactorVI(byte decatype)
        {
            if (decatype >= 7) return "Alto: Señala a una persona con voluntad de dominio, con deseos de ganar, de manipular, persuasivo y cautivador, es dominante y con actitud ascendente propia de personas con jerarquía.";
            if (decatype >= 5) return "Promedio: Señala a una persona con voluntad de dominio, de manipular, persuadir y/o cautivar.";
            if (decatype >= 1) return "Bajo: Señala a una persona con poca voluntad de dominio, de manipular, persuadir y/o cautivar.";

            return string.Empty;
        }

        private static string GetDescription_FactorVII(byte decatype)
        {
            if (decatype >= 7) return "Alto: Es un individuo seguro de sí mismo, que le gustan las situaciones novedosas e inesperadas, capaz de enfrentarse a riesgos.";
            if (decatype >= 5) return "Promedio: Señala a una persona con voluntad promedio de dominio, capaz de manipular, persuadir y/o cautivar.";
            if (decatype >= 1) return "Bajo: Es seguro, no goza de situaciones novedosas e inesperadas, difícilmente se enfrentaría a riesgos.";

            return string.Empty;
        }

        private static string GetDescription_FactorVIII(byte decatype)
        {
            if (decatype >= 7) return "Alto: Es una persona que le gustan las actividades deportivas, es activo.";
            if (decatype >= 5) return "Promedio: El índice de actividad se sitúa dentro del promedio, muestra a una persona que gusta de actividades deportivas, no soporta la pasividad física.";
            if (decatype >= 1) return "Bajo: Es una persona que no gusta de actividades deportivas, suele ser pasivo.";

            return string.Empty;
        }
        
        private static string GetDescription_FactorIX(byte decatype)
        {
            if (decatype >= 7) return "Alto: Es extrovertido, capaz de crear nuevos contactos y convivir con los demás, es sensible a las relaciones humanas y prefiere estar acompañado que solo.";
            if (decatype >= 5) return "Promedio: El índice de sociabilidad promedio, muestra a una persona extrovertida, capaz de crear nuevos contactos y convivir con los demás, sensible a las relaciones humanas y el cual prefiere estar acompañado que solo.";
            if (decatype >= 1) return "Bajo: Es una persona tímida con una actitud pasiva, evita mantener contactos sociales, prefiere realizar las cosas de una manera individual, no le agrada trabajar en grupo.";

            return string.Empty;
        }

    }
}