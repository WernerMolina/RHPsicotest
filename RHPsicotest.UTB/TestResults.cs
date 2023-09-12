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

        public async Task<bool> GenerateResults_Test_PPGIPG(char[][] responses, int candidateId, int testId)
        {
            byte[] scoresByFactor = Results_PPGIPG.GetScoresByFactor(responses);

            // Traemos el expediente del candidato que esta realizando la prueba
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            // Guarda el genero, la edad y la formación académica del candidato
            (string, byte, string) infoCandidate = (expedient.Gender, expedient.Age, expedient.AcademicTraining);

            // Guarda los percentiles de todos los factores
            byte[] percentiles = Results_PPGIPG.GetPercentilesByFactor(scoresByFactor, infoCandidate);

            // Guarda las descripciones de todos los factores
            string[] descriptions = Results_PPGIPG.GetDescriptionsByPercentile(percentiles);

            bool result = await AddResults_PPGIPG(candidateId, testId, expedient.IdExpedient, scoresByFactor, percentiles, descriptions);

            return result;
        }

        public async Task<bool> GenerateResults_Test_Dominos(char?[][] responses, int candidateId, int testId)
        {
            byte score = Results_Dominos.GetScoreTotal(responses);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            byte percentile = Results_Dominos.GetPercentileByScore(score, expedient.AcademicTraining);

            string description = Results_Dominos.GetDescriptionByPercentile(percentile);

            return await AddResults_Dominos(candidateId, testId, expedient.IdExpedient, score, percentile, description);
        }

        public async Task<bool> GenerateResults_Test_IPV(char[] responses, int candidateId, int testId)
        {
            byte[] scoresByFactor = Results_IPV.GetScoresByFactor(responses);

            byte[] decatypesByFactor = Results_IPV.GetDecatypesByFactor(scoresByFactor);

            string[] descriptions = Results_IPV.GetDescriptionsByFactor(decatypesByFactor);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            bool result = await AddResults_IPV(candidateId, testId, expedient.IdExpedient, scoresByFactor, decatypesByFactor, descriptions);

            return result;
        }


        private async Task<bool> AddResults_PPGIPG(int candidateId, int testId, int expedientId, byte[] scoresByFactor, byte[] percentilesByFactor, string[] descriptions)
        {
            bool resultSave;

            DeleteTestResult(expedientId, testId);

            List<Result> results = new List<Result>();

            for (byte i = 0; i <= 8; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, testId, i + 1, scoresByFactor[i], percentilesByFactor[i], descriptions[i]));
            }

            await context.Results.AddRangeAsync(results);
            resultSave = await context.SaveChangesAsync() > 0;

            if (resultSave) ChangedTestStatus(candidateId, testId);

            return resultSave;
        }

        private async Task<bool> AddResults_Dominos(int candidateId, int testId, int expedientId, byte score, byte percentile, string description)
        {
            bool resultSave;

            DeleteTestResult(expedientId, testId);

            Result result = Conversion.ConvertToResult(expedientId, testId, 10, score, percentile, description);

            await context.Results.AddAsync(result);
            resultSave = await context.SaveChangesAsync() > 0;

            if (resultSave) ChangedTestStatus(candidateId, testId);

            return resultSave;
        }

        private async Task<bool> AddResults_IPV(int candidateId, int testId, int expedientId, byte[] scoresByFactor, byte[] decatypesByFactor, string[] descriptions)
        {
            bool resultSave;

            DeleteTestResult(expedientId, testId);

            byte factorId = 31;
            List<Result> results = new List<Result>();

            for (byte i = 0; i <= 11; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, testId, factorId++, scoresByFactor[i], decatypesByFactor[i], descriptions[i]));
            }

            await context.Results.AddRangeAsync(results);
            resultSave = await context.SaveChangesAsync() > 0;

            if (resultSave) ChangedTestStatus(candidateId, testId);

            return resultSave;
        }



        private void DeleteTestResult(int expedientId, int testId)
        {
            List<Result> results = context.Results.AsNoTracking().Where(r => r.IdExpedient == expedientId && r.IdTest == testId).ToList();

            if (results.Count > 0)
            {
                context.Results.RemoveRange(results);
                context.SaveChanges();
            }
        }

        private void ChangedTestStatus(int candidateId, int testId)
        {
            Test_Candidate testCandidate = context.Test_Candidates.AsNoTracking().FirstOrDefault(t => t.IdTest == testId && t.IdCandidate == candidateId);

            testCandidate.Status = true;

            context.Test_Candidates.Update(testCandidate);
            context.SaveChanges();
        }

    }
}
