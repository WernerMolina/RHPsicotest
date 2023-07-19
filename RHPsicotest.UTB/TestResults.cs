using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.GenerateResults;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHPsicotest.UTB
{
    public class TestResults
    {
        public RHPsicotestContext context = new RHPsicotestContext();

        public bool GenerateResults_Test_PPGIPG(char[][] responses, int currentIdUser)
        {
            byte[] scoresByFactor = Results_PPGIPG.GetScoresByFactor(responses);

            // Traemos el expediente del candidato que esta realizando la prueba
            Expedient expedient = context.Expedients.FirstOrDefault(e => e.IdCandidate == currentIdUser);

            // Guarda el genero, la edad y la formación académica del candidato
            (string, byte, string) infoCandidate = (expedient.Gender, expedient.Age, expedient.AcademicTraining);

            // Guarda los percentiles de todos los factores
            byte[] percentiles = Results_PPGIPG.GetPercentilesByFactor(scoresByFactor, infoCandidate);

            // Guarda las descripciones de todos los factores
            string[] descriptions = Results_PPGIPG.GetDescriptionsByPercentile(percentiles);

            bool result = AddResults_PPGIPG(expedient.IdExpedient, scoresByFactor, percentiles, descriptions);

            return result;
        }

        public bool GenerateResults_Test_Dominos(char?[][] responses, int currentIdUser)
        {
            byte score = Results_Dominos.GetScoreTotal(responses);

            Expedient expedient = context.Expedients.FirstOrDefault(e => e.IdCandidate == currentIdUser);

            byte percentile = Results_Dominos.GetPercentileByScore(score, expedient.AcademicTraining);

            string description = Results_Dominos.GetDescriptionByPercentile(percentile);

            return AddResults_Dominos(expedient.IdExpedient, score, percentile, description);
        }

        private bool AddResults_PPGIPG(int expedientId, byte[] scoresByFactor, byte[] percentilesByFactor, string[] descriptions)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId && r.IdTest == 1).ToList();

            if (removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            for (byte i = 0; i <= 8; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, 1, i + 1, scoresByFactor[i], percentilesByFactor[i], descriptions[i]));
            }

            context.Results.AddRange(results);
            return context.SaveChanges() > 0;
        }

        private bool AddResults_Dominos(int expedientId, byte score, byte percentile, string description)
        {
            Result remove = context.Results.FirstOrDefault(r => r.IdExpedient == expedientId && r.IdTest == 3);

            if (remove != null)
            {
                context.Results.Remove(remove);
                context.SaveChanges();
            }

            Result result = Conversion.ConvertToResult(expedientId, 3, 10, score, percentile, description);

            context.Results.AddAsync(result);
            return context.SaveChanges() > 0;
        }

    }
}
