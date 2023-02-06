using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<bool> GenerateResults(string[][] candidateAnswers)
        {
            int positives = 0;
            int negatives = 0;
            int total = 0;
            int i = 0;

            var responsesByFactor = await GetResponsesByFactor(1);

            foreach (var response in responsesByFactor)
            {
                string correct = response.Correct;
                string incorrect = response.InCorrect;

                bool a = false;
                bool b = false;
                bool c = false;
                bool d = false;

                if (correct.Length == 1)
                {
                    switch (correct)
                    {
                        case "A":
                            a = true;
                            break;
                        case "B":
                            b = true;
                            break;
                        case "C":
                            c = true;
                            break;
                        case "D":
                            d = true;
                            break;
                    }
                }
                else
                {
                    switch (incorrect)
                    {
                        case "A":
                            b = true;
                            c = true;
                            d = true;
                            break;
                        case "B":
                            a = true;
                            c = true;
                            d = true;
                            break;
                        case "C":
                            a = true;
                            b = true;
                            d = true;
                            break;
                        case "D":
                            a = true;
                            b = true;
                            c = true;
                            break;
                    }
                }

                string positive = candidateAnswers[i][0];
                string negative = candidateAnswers[i][1];

                bool? ap = null;
                bool? bp = null;
                bool? cp = null;
                bool? dp = null;

                bool? an = null;
                bool? bn = null;
                bool? cn = null;
                bool? dn = null;

                switch (positive)
                {
                    case "A":
                        ap = true;
                        break;
                    case "B":
                        bp = true;
                        break;
                    case "C":
                        cp = true;
                        break;
                    case "D":
                        dp = true;
                        break;
                }

                switch (negative)
                {
                    case "A":
                        an = false;
                        break;
                    case "B":
                        bn = false;
                        break;
                    case "C":
                        cn = false;
                        break;
                    case "D":
                        dn = false;
                        break;
                }

                if (ap == a) positives++;
                if (bp == b) positives++;
                if (cp == c) positives++;
                if (dp == d) positives++;

                if (an == a) negatives++;
                if (bn == b) negatives++;
                if (cn == c) negatives++;
                if (dn == d) negatives++;

                i++;
            }

            total = positives + negatives;

            return true;
        }

        private async Task<IEnumerable<Factor_Question>> GetResponsesByFactor(int id)
        {
            return await context.Factor_Questions.Where(d => d.IdFactor == id).ToListAsync();
        }
    }
}
