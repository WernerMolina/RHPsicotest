using RHPsicotest.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ITestRepository
    {
        public Task<Test> GetTest();
        public Task<bool> GenerateResults(string[][] candidateAnswers);
    }
}
