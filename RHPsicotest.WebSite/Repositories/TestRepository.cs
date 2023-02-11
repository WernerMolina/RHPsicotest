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

        public async Task<bool> TestPPG_IPG(char[][] responses, int currentIdUser)
        {
            int[] scoresByFactors = new int[9];

            for (int i = 1; i < 8; i++)
            {
                IEnumerable<Response> responsesByFactor = await GetResponsesByFactor(i);
                
                if(i <= 4)
                {
                    char[,] responsesPPG = new char[18, 2];

                    for (int j = 0; j <= 4; j++)
                    {
                        responsesPPG[j, 0] = responses[j][0];
                        responsesPPG[j, 1] = responses[j][1];
                    }

                    int scores = GenerateResults.GetPointsByFactor(responsesPPG, responsesByFactor);

                    scoresByFactors[i - 1] = scores;
                }
                //else
                //{
                //    int k = 18;
                //    char[,] responsesIPG = new char[38, 2];

                //    for (int j = 0; j <= 19; j++)
                //    {
                //        responsesIPG[j, 0] = responses[k][0];
                //        responsesIPG[j, 1] = responses[k][1];

                //        k++;
                //    }

                //    int scores = GenerateResults.GetPointsByFactor(responsesIPG, responsesByFactor);

                //    scoresByFactors[i - 1] = scores;
                //}
            }

            scoresByFactors[8] = scoresByFactors[0] + scoresByFactors[1] + scoresByFactors[2] + scoresByFactors[3];

            Expedient expedient = await context.Expedients.FirstOrDefaultAsync(e => e.IdExpedient == currentIdUser);
            
            (string, byte) infoCandidate = (expedient.Gender, Helper.CalculateAge(expedient.DateOfBirth));

            int[] percentiles = GenerateResults.GetPercentileByFactor(scoresByFactors, infoCandidate); ;


            return true;
        }

        private async Task<IEnumerable<Response>> GetResponsesByFactor(int id)
        {
            return await context.Responses.Where(d => d.IdFactor == id).ToListAsync();
        }
        
        //private Candidate GetExpedient(int id)
        //{
        //    return context.Candidates.Where(c => c.IdUser == id);
        //}
    }
}
