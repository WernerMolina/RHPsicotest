using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Tests.Questions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ITestRepository
    {
        public List<PPGIPG> GetTest_PPGIPG();
        public List<OTIS> GetTest_OTIS();
        public List<BFQ> GetTest_BFQ();

        public Task<List<Test>> GetAssignedTests(int candidateId);

        public Task<(bool, byte[], byte[])> Test_PPGIPG(char[][] responses, int currentIdUser);
        //public Task<(bool, byte[], byte[])> Test_OTIS(char[] responses, int currentIdUser);
    }
}
