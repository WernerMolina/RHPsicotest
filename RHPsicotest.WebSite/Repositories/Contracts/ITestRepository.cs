using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Tests.Questions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories.Contracts
{
    public interface ITestRepository
    {
        public List<Questions_BFQ> GetTest_BFQ();

        public List<Questions_OTIS> GetTest_OTIS();

        public List<Questions_PPGIPG> GetTest_PPGIPG();

        public List<Questions_16PF> GetTest_16PF_A();

        public List<Questions_16PF> GetTest_16PF_B();

        public Task<List<TestDTO>> GetAssignedTests(int candidateId);

        public Task<bool> Test_PPGIPG(char[][] responses, int currentIdUser);

        public Task<bool> Test_Dominos(char?[][] responses, int currentIdUser);

        public Task<bool> Test_OTIS(char[] responses, int currentIdUser);

        public Task<bool> Test_16PF(char[] responses, int currentIdUser, bool isWayA);

    }
}
