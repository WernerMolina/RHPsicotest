using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.GenerateResults;
using RHPsicotest.WebSite.Tests.Questions;
using RHPsicotest.WebSite.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly RHPsicotestDbContext context;

        public TestRepository(RHPsicotestDbContext context)
        {
            this.context = context;
        }

        public List<Questions_PPGIPG> GetQuestions_Test_PPGIPG()
        {
            return Questions_PPGIPG.GetQuestions();
        }

        public List<Questions_OTIS> GetQuestions_Test_OTIS()
        {
            return Questions_OTIS.GetQuestions();
        }

        public List<Questions_BFQ> GetQuestions_Test_BFQ()
        {
            return Questions_BFQ.GetQuestions();
        }

        public List<Questions_16PF> GetQuestions_Test_16PF_A()
        {
            return Questions_16PF.GetQuestions_WayA();
        }

        public List<Questions_16PF> GetQuestions_Test_16PF_B()
        {
            return Questions_16PF.GetQuestions_WayB();
        }
        
        public List<Questions_IPV> GetQuestions_Test_IPV()
        {
            return Questions_IPV.GetQuestions();
        }

        public async Task<List<TestDTO>> GetAssignedTests(int candidateId)
        {
            List<Test_Candidate> tests = await context.Test_Candidates.Where(t => t.IdCandidate == candidateId).ToListAsync();

            List<TestDTO> testDTOs = new List<TestDTO>();

            if (tests != null)
            {
                foreach (Test_Candidate testCandidate in tests)
                {
                    Test test = await context.Tests.FirstOrDefaultAsync(t => t.IdTest == testCandidate.IdTest);

                    testDTOs.Add(Conversion.ConvertToTestDTO(test, testCandidate.Status));
                }
            }

            return testDTOs;
        }

        public async Task<bool> GenerateResults_Test_PPGIPG(char[][] responses, int currentIdUser)
        {
            byte[] scoresByFactor = Results_PPGIPG.GetScoresByFactor(responses);

            // Traemos el expediente del candidato que esta realizando la prueba
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            // Guarda el genero, la edad y la formación académica del candidato
            (string, byte, string) infoCandidate = (expedient.Gender, expedient.Age, expedient.AcademicTraining);

            // Guarda los percentiles de todos los factores
            byte[] percentiles = Results_PPGIPG.GetPercentilesByFactor(scoresByFactor, infoCandidate);

            // Guarda las descripciones de todos los factores
            string[] descriptions = Results_PPGIPG.GetDescriptionsByPercentile(percentiles);

            bool result = await AddResults_PPGIPG(expedient.IdExpedient, scoresByFactor, percentiles, descriptions);

            return result;
        }

        public async Task<bool> GenerateResults_Test_Dominos(char?[][] responses, int currentIdUser)
        {
            byte score = Results_Dominos.GetScoreTotal(responses);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            byte percentile = Results_Dominos.GetPercentileByScore(score, expedient.AcademicTraining);

            string description = Results_Dominos.GetDescriptionByPercentile(percentile);

            return await AddResults_Dominos(expedient.IdExpedient, score, percentile, description);
        }

        public async Task<bool> GenerateResults_Test_OTIS(char[] responses, int currentIdUser)
        {
            byte score = Results_OTIS.GetScoreTotal(responses);

            byte iq = Results_OTIS.GetIQByScore(score);

            string description = Results_OTIS.GetDescriptionByIQ(iq);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            bool result = await AddResults_OTIS(expedient.IdExpedient, score, iq, description);

            return result;
        }

        public async Task<bool> GenerateResults_Test_16PF(char[] responses, int currentIdUser, bool isWayA)
        {
            byte[] scoresPrimaryFactors = Results_16PF.GetScoresByFactor(responses);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            byte[] decatypesByFactor = Results_16PF.GetDecatypesByFactor(scoresPrimaryFactors, expedient.Gender, isWayA);

            byte[] scoresSecondaryFactors = Results_16PF.GetScoresOfSecondaryFactors(decatypesByFactor, expedient.Gender);

            string[] descriptionsPrimaryFactors = Results_16PF.GetDescriptionsPrimaryFactors(decatypesByFactor);

            string[] descriptionsSecondaryFactors = Results_16PF.GetDescriptionsSecondaryFactors(decatypesByFactor);

            byte[] scoresByFactor = scoresPrimaryFactors.Concat(scoresSecondaryFactors).ToArray();

            string[] descriptionsByFactor = descriptionsPrimaryFactors.Concat(descriptionsSecondaryFactors).ToArray();

            bool result = await AddResults_16PF(expedient.IdExpedient, scoresPrimaryFactors, scoresByFactor, decatypesByFactor, descriptionsByFactor, isWayA);

            return result;
        }

        public async Task<bool> GenerateResults_Test_IPV(char[] responses, int currentIdUser)
        {
            byte[] scoresByFactor = Results_IPV.GetScoresByFactor(responses);

            byte[] decatypesByFactor = Results_IPV.GetDecatypesByFactor(scoresByFactor);

            string[] descriptions = Results_IPV.GetDescriptionsByFactor(decatypesByFactor);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            bool result = await AddResults_IPV(expedient.IdExpedient, scoresByFactor, decatypesByFactor, descriptions);

            return result;
        }


        // Guarda el puntaje por factor, percentil y descripción
        private async Task<bool> AddResults_PPGIPG(int expedientId, byte[] scoresByFactor, byte[] percentilesByFactor, string[] descriptions)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId && r.IdTest == 1).ToList();

            if(removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            for (byte i = 0; i <= 8; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, 1, i + 1, scoresByFactor[i], percentilesByFactor[i], descriptions[i]));
            }

            await context.Results.AddRangeAsync(results);
            return await context.SaveChangesAsync() > 0;
        }

        private async Task<bool> AddResults_OTIS(int expedientId, byte score, byte IQ, string description)
        {
            Result remove = await context.Results.FirstOrDefaultAsync(r => r.IdExpedient == expedientId && r.IdTest == 2);

            if (remove != null)
            {
                context.Results.Remove(remove);
                context.SaveChanges();
            }

            Result result = Conversion.ConvertToResult(expedientId, 2, 10, score, IQ, description);
            
            await context.Results.AddAsync(result);
            return await context.SaveChangesAsync() > 0;
        }

        private async Task<bool> AddResults_Dominos(int expedientId, byte score, byte percentile, string description)
        {
            Result remove = await context.Results.FirstOrDefaultAsync(r => r.IdExpedient == expedientId && r.IdTest == 3);

            if (remove != null)
            {
                context.Results.Remove(remove);
                context.SaveChanges();
            }

            Result result = Conversion.ConvertToResult(expedientId, 3, 10, score, percentile, description);

            await context.Results.AddAsync(result);
            return await context.SaveChangesAsync() > 0;
        }

        private async Task<bool> AddResults_16PF(int expedientId, byte[] scoresPrimaryFactors, byte[] scoresSecondaryFactors, byte[] decatypesByFactor, string[] descriptions, bool isWayA)
        {
            int testId = isWayA ? 5 : 6;

            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId && r.IdTest == testId).ToList();

            if (removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            byte factorId = 11;

            for (byte i = 0; i <= 15; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, testId, factorId++, scoresPrimaryFactors[i], decatypesByFactor[i], descriptions[i]));
            }

            await context.Results.AddRangeAsync(results);
            return await context.SaveChangesAsync() > 0;
        }

        private async Task<bool> AddResults_IPV(int expedientId, byte[] scoresByFactor, byte[] decatypesByFactor, string[] descriptions)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId && r.IdTest == 7).ToList();

            if(removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            byte factorId = 31;

            for (byte i = 0; i <= 11; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, 7, factorId++, scoresByFactor[i], decatypesByFactor[i], descriptions[i]));
            }

            await context.Results.AddRangeAsync(results);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
