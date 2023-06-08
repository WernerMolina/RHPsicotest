using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.GenerateResults;
using RHPsicotest.WebSite.Tests.Questions;
using RHPsicotest.WebSite.Tests.Responses;
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

        public List<Questions_PPGIPG> GetTest_PPGIPG()
        {
            return Questions_PPGIPG.Questions();
        }
        
        public List<Questions_OTIS> GetTest_OTIS()
        {
            return Questions_OTIS.Questions();
        }
        
        public List<Questions_BFQ> GetTest_BFQ()
        {
            return Questions_BFQ.Questions();
        }
        
        public List<Questions_16PF> GetTest_16PF_A()
        {
            return Questions_16PF.Questions_WayA();
        }
        
        public List<Questions_16PF> GetTest_16PF_B()
        {
            return Questions_16PF.Questions_WayB();
        }
        
        public async Task<List<TestDTO>> GetAssignedTests(int candidateId)
        {
            List<Test_Candidate> tests = await context.Test_Candidates.Where(t => t.IdCandidate == candidateId).ToListAsync();

            List<TestDTO> testDTOs = new List<TestDTO>(); 

            if (tests != null)
            {
                foreach (var testCandidate in tests)
                {
                    Test test = await context.Tests.FirstOrDefaultAsync(t => t.IdTest == testCandidate.IdTest);

                    testDTOs.Add(Conversion.ConvertToTestDTO(test, testCandidate.Status));
                }
            }

            return testDTOs;
        }

        public async Task<bool> Test_PPGIPG(char[][] responses, int currentIdUser)
        {
            byte[] scoresByFactor = Results_PPGIPG.GetScores(responses);

            // Traemos el expediente del candidato que esta realizando la prueba
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);
            
            // Guarda el genero, la edad y la formacion academica del candidato
            (string, byte, string) infoCandidate = (expedient.Gender, expedient.Age, expedient.AcademicTraining);

            // Guarda los percentiles de todos los factores
            byte[] percentiles = Results_PPGIPG.GetPercentileByFactor(scoresByFactor, infoCandidate);

            // Guarda las descripciones de todos los factores
            string[] descriptions = Results_PPGIPG.GetDescriptionByPercentile(percentiles);

            bool result = await AddResults_PPGIPG(expedient.IdExpedient, scoresByFactor, percentiles, descriptions);

            return result;
        }

        public async Task<bool> Test_Dominos(char?[][] responses, int currentIdUser)
        {
            byte score = Results_Dominos.GetScoreTotal(responses);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            byte percentile = Results_Dominos.GetPercentileByScore(score, expedient.AcademicTraining);

            string description = Results_Dominos.GetDescriptionByPercentile(percentile);

            return await AddResults_Dominos(expedient.IdExpedient, score, percentile, description); 
        }

        public async Task<bool> Test_OTIS(char[] responses, int currentIdUser)
        {
            byte score = Results_OTIS.GetScoreTotal(responses);

            byte IQ = Results_OTIS.GetCIByScore(score);

            string description = Results_OTIS.GetDescriptionByCI(IQ);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            bool result = await AddResults_OTIS(expedient.IdExpedient, score, IQ, description);

            return result;
        }


        // Guarda el puntaje por factor, percentil y descripción
        private async Task<bool> AddResults_PPGIPG(int expedientId, byte[] scoresByFactor, byte[] scoresByPercentile, string[] description)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId && r.IdTest == 1).ToList();

            if(removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            for (int i = 0; i <= 8; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, 1, i + 1, scoresByFactor[i], scoresByPercentile[i], description[i]));
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
    }
}
