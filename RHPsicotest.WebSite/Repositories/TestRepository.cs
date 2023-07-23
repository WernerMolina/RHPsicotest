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
using RHPsicotest.WebSite.ViewModels;

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


        // Generan los datos de su respectiva prueba
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

        public async Task<bool> GenerateResults_Test_OTIS(char[] responses, int candidateId, int testId)
        {
            byte score = Results_OTIS.GetScoreTotal(responses);

            byte iq = Results_OTIS.GetIQByScore(score);

            string description = Results_OTIS.GetDescriptionByIQ(iq);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            bool result = await AddResults_OTIS(candidateId, testId, expedient.IdExpedient, score, iq, description);

            return result;
        }

        public async Task<bool> GenerateResults_Test_16PF(char[] responses, int candidateId, int testId, bool isWayA)
        {
            byte[] scoresPrimaryFactors = Results_16PF.GetScoresByFactor(responses);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            byte[] decatypesByFactor = Results_16PF.GetDecatypesByFactor(scoresPrimaryFactors, expedient.Gender, isWayA);

            byte[] scoresSecondaryFactors = Results_16PF.GetScoresOfSecondaryFactors(decatypesByFactor, expedient.Gender);

            string[] descriptionsPrimaryFactors = Results_16PF.GetDescriptionsPrimaryFactors(decatypesByFactor);

            string[] descriptionsSecondaryFactors = Results_16PF.GetDescriptionsSecondaryFactors(decatypesByFactor);

            byte[] scoresByFactor = scoresPrimaryFactors.Concat(scoresSecondaryFactors).ToArray();

            string[] descriptionsByFactor = descriptionsPrimaryFactors.Concat(descriptionsSecondaryFactors).ToArray();

            bool result = await AddResults_16PF(expedient.IdExpedient, scoresPrimaryFactors, scoresByFactor, decatypesByFactor, descriptionsByFactor, isWayA);

            return result;
        }

        public async Task<bool> GenerateResults_Test_IPV(char[] responses, int candidateId, int testId)
        {
            byte[] scoresByFactor = Results_IPV.GetScoresByFactor(responses);

            byte[] decatypesByFactor = Results_IPV.GetDecatypesByFactor(scoresByFactor);

            string[] descriptions = Results_IPV.GetDescriptionsByFactor(decatypesByFactor);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == candidateId);

            bool result = await AddResults_IPV(expedient.IdExpedient, scoresByFactor, decatypesByFactor, descriptions);

            return result;
        }


        // Guarda los datos de su respectiva prueba en la base de datos
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

        private async Task<bool> AddResults_OTIS(int candidateId, int testId, int expedientId, byte score, byte iq, string description)
        {
            bool resultSave;

            DeleteTestResult(expedientId, testId);

            Result result = Conversion.ConvertToResult(expedientId, testId, 10, score, iq, description);
            
            await context.Results.AddAsync(result);
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

            if(resultSave) ChangedTestStatus(candidateId, testId);

            return resultSave;
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


        // Métodos de reutilidad
        public async Task<bool> HasCompleteTest(int candidateId, int testId)
        {
            Test_Candidate testCandidate = await context.Test_Candidates.FirstOrDefaultAsync(t => t.IdTest == testId && t.IdCandidate == candidateId);

            if (testCandidate != null)
            {
                return testCandidate.Status;
            }

            return true;
        }

        public async Task<int> GetTestId(string testName)
        {
            Test test = await context.Tests.FirstOrDefaultAsync(t => t.NameTest == testName);

            return test.IdTest;
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
