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
        public List<Questions_BFQ> GetQuestions_Test_BFQ();

        public List<Questions_OTIS> GetQuestions_Test_OTIS();

        public List<Questions_PPGIPG> GetQuestions_Test_PPGIPG();

        public List<Questions_16PF> GetQuestions_Test_16PF_A();

        public List<Questions_16PF> GetQuestions_Test_16PF_B();

        public List<Questions_IPV> GetQuestions_Test_IPV();

        public Task<List<TestDTO>> GetAssignedTests(int candidateId);

        public Task<bool> GenerateResults_Test_PPGIPG(char[][] responses, int currentIdUser);

        public Task<bool> GenerateResults_Test_Dominos(char?[][] responses, int currentIdUser);

        public Task<bool> GenerateResults_Test_OTIS(char[] responses, int currentIdUser);

        public Task<bool> GenerateResults_Test_16PF(char[] responses, int currentIdUser, bool isWayA);

        public Task<bool> GenerateResults_Test_IPV(char[] responses, int currentIdUser);


    }
}
