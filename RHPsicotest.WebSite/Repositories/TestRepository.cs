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
            byte[] scoresByFactor = new byte[9];

            for (int i = 1; i <= 8; i++)
            {
                List<Responses_PPGIPG> responsesByFactor = Responses_PPGIPG.GetResponses().Where(r => r.IdFactor == i).ToList();
                
                if(i <= 4)
                {
                    // Obtenemos las puntuaciones de la pregunta 1 a la 18
                    char[,] responsesPPG = new char[18, 2];

                    for (int j = 0; j < 18; j++)
                    {
                        responsesPPG[j, 0] = responses[j][0];
                        responsesPPG[j, 1] = responses[j][1];
                    }

                    byte scores = Results_PPGIPG.GetScoreByFactor(responsesPPG, responsesByFactor);

                    scoresByFactor[i - 1] = scores;
                }
                else
                {
                    // Obtenemos las puntuaciones de la pregunta 19 a la 38
                    int k = 18;
                    char[,] responsesIPG = new char[20, 2];

                    for (int j = 0; j < 20; j++)
                    {
                        responsesIPG[j, 0] = responses[k][0];
                        responsesIPG[j, 1] = responses[k][1];

                        k++;
                    }

                    byte scores = Results_PPGIPG.GetScoreByFactor(responsesIPG, responsesByFactor);

                    scoresByFactor[i - 1] = scores;
                }
            }

            // Suma para obtener el factor de Autoestima
            scoresByFactor[8] = (byte)(scoresByFactor[0] + scoresByFactor[1] + scoresByFactor[2] + scoresByFactor[3]);

            // Traemos el expediente del candidato que esta realizando la prueba
            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);
            
            // Guarda el genero, la edad y la formacion academica del candidato
            (string, byte, string) infoCandidate = (expedient.Gender, expedient.Age, expedient.Certificate);

            // Guarda los percentiles de todos los factores
            byte[] percentiles = Results_PPGIPG.GetPercentileByFactor(scoresByFactor, infoCandidate);

            // Guarda las descripciones de todos los factores
            string[] descriptions = Results_PPGIPG.GetDescriptionByPercentile(percentiles);

            bool result = await AddResults_PPGIPG(expedient.IdExpedient, scoresByFactor, percentiles, descriptions);

            return result;
        }

        public async Task<bool> Test_Dominos(char[][] responses, int currentIdUser)
        {
            byte?[,] responsesInByte = new byte?[44, 2];

            for (int i = 0; i < 11; i++)
            {
                responsesInByte[i, 0] = Convert.ToByte(responses[i][0]);
                responsesInByte[i, 1] = Convert.ToByte(responses[i][1]);

                if (responsesInByte[i, 0] < 0 ||
                    responsesInByte[i, 0] > 6 ||
                    responsesInByte[i, 1] < 0 ||
                    responsesInByte[i, 1] > 6) return false;
            }

            byte score = Results_Dominos.GetScoreTotal(responsesInByte);

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdCandidate == currentIdUser);

            byte percentile = Results_Dominos.GetPercentileByScore(score, expedient.AcademicTraining);

            return true;
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


        // Guarda el puntaje por factor y percentil
        private async Task<bool> AddResults_PPGIPG(int expedientId, byte[] scoresByFactor, byte[] scoresByPercentile, string[] description)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId).ToList();

            if(removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            for (int i = 0; i <= 8; i++)
            {
                results.Add(Conversion.ConvertToResult(expedientId, i + 1, scoresByFactor[i], scoresByPercentile[i], description[i]));
            }

            await context.Results.AddRangeAsync(results);
            return await context.SaveChangesAsync() > 0;
        }

        private async Task<bool> AddResults_OTIS(int expedientId, byte score, byte IQ, string description)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == expedientId).ToList();

            if (removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            Result result = Conversion.ConvertToResult(expedientId, 10, score, IQ, description);
            
            await context.Results.AddAsync(result);
            return await context.SaveChangesAsync() > 0;
        }

        private async Task<bool> AddResults_Dominos(int expedientId, byte score, byte percentile, string description)
        {
            Result removes = await context.Results.FirstOrDefaultAsync(r => r.IdExpedient == expedientId && r.IdFactor == 9);

            if (removes != null)
            {
                context.Results.Remove(removes);
                context.SaveChanges();
            }

            Result result = Conversion.ConvertToResult(expedientId, 10, score, percentile, description);

            await context.Results.AddAsync(result);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
