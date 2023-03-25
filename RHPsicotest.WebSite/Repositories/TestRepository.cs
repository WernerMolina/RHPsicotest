using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
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

        public List<PPGIPG> GetTest_PPGIPG()
        {
            return PPGIPG.Questions();
        }
        
        public List<OTIS> GetTest_OTIS()
        {
            return OTIS.Questions();
        }
        
        public List<BFQ> GetTest_BFQ()
        {
            return BFQ.Questions();
        }
        
        public async Task<List<Test>> GetAssignedTests(int candidateId)
        {
            Candidate candidate = await context.Candidates.Include(c => c.Position.Tests).FirstOrDefaultAsync(c => c.IdCandidate == candidateId);

            List<Test> tests = new List<Test>();

            if (candidate != null)
            {
                foreach (var item in candidate.Position.Tests)
                {
                    Test test = await context.Tests.FirstOrDefaultAsync(t => t.IdTest == item.IdTest);

                    tests.Add(test);
                }
            }

            return tests;
        }

        public async Task<(bool, byte[], byte[])> Test_PPGIPG(char[][] responses, int currentIdUser)
        {
            byte[] scoresByFactor = new byte[9];

            // Retorna falso si la respuesta positiva y negativa tienen el mismo valor en un pregunta
            for (int i = 0; i < 38; i++)
            {
                if (responses[i][0] == responses[i][1]) return (false, null, null);
            }

            for (int i = 1; i <= 8; i++)
            {
                List<R_PPGIPG> responsesByFactor = R_PPGIPG.GetResponses().Where(r => r.IdFactor == i).ToList();
                
                if(i <= 4)
                {
                    // Obtenemos las puntuaciones de la pregunta 1 a la 18
                    char[,] responsesPPG = new char[18, 2];

                    for (int j = 0; j < 18; j++)
                    {
                        responsesPPG[j, 0] = responses[j][0];
                        responsesPPG[j, 1] = responses[j][1];
                    }

                    byte scores = GenerateResults.GetScoreByFactor(responsesPPG, responsesByFactor);

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

                    byte scores = GenerateResults.GetScoreByFactor(responsesIPG, responsesByFactor);

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
            byte[] percentiles = GenerateResults.GetPercentileByFactor(scoresByFactor, infoCandidate);

            // Guarda las descripciones de todos los factores
            string[] descriptions = GenerateResults.GetDescriptionByPercentile(percentiles);

            bool result = await AddResults(expedient.IdExpedient, scoresByFactor, percentiles, descriptions);

            return (result, scoresByFactor, percentiles);
        }

        // Guarda el puntaje por factor y percentil
        private async Task<bool> AddResults(int id, byte[] scoresByFactor, byte[] scoresByPercentile, string[] description)
        {
            List<Result> results = new List<Result>();
            List<Result> removes = context.Results.Where(r => r.IdExpedient == id).ToList();

            if(removes != null)
            {
                context.Results.RemoveRange(removes);
                context.SaveChanges();
            }

            for (int i = 0; i <= 8; i++)
            {
                results.Add(Conversion.ConvertToResult(id, i + 1, scoresByFactor[i], scoresByPercentile[i], description[i]));
            }

            await context.Results.AddRangeAsync(results);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
