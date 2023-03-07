using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
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

        public async Task<Test> GetTest()
        {
            return await context.Tests.Include("Questions.Test").FirstOrDefaultAsync(t => t.IdTest == 1);
        }

        public async Task<(bool, byte[], byte[])> TestPPG_IPG(char[][] responses, int currentIdUser)
        {
            byte[] scoresByFactor = new byte[9];

            // Retorna falso si la respuesta positiva y negativa tienen el mismo valor en un pregunta
            for (int i = 0; i < 38; i++)
            {
                if (responses[i][0] == responses[i][1]) return (false, null, null);
            }

            for (int i = 1; i <= 8; i++)
            {
                IEnumerable<Response> responsesByFactor = await GetResponsesByFactor(i);
                
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
            (string, byte, string) infoCandidate = (expedient.Gender, 20, expedient.AcademicTraining);

            // Guarda los percentiles de cada factor 
            byte[] percentiles = GenerateResults.GetPercentileByFactor(scoresByFactor, infoCandidate);

            bool result = await AddResults(expedient.IdExpedient, scoresByFactor, percentiles);

            return (result, scoresByFactor, percentiles);
        }

        private async Task<IEnumerable<Response>> GetResponsesByFactor(int id)
        {
            return await context.Responses.Where(d => d.IdFactor == id).ToListAsync();
        }

        // Guarda el puntaje por factor y percentil
        private async Task<bool> AddResults(int id, byte[] scoresByFactor, byte[] scoresByPercentile)
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
                results.Add(Conversion.ConvertToResult(id, i + 1, scoresByFactor[i], scoresByPercentile[i]));
            }

            await context.Results.AddRangeAsync(results);
            return await context.SaveChangesAsync() > 0;
        }
    }
}
