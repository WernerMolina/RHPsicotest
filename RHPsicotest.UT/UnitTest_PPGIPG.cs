using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RHPsicotest.WebSite.Controllers;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Repositories;
using RHPsicotest.WebSite.Repositories.Contracts;
using System;
using System.Threading.Tasks;

namespace RHPsicotest.UT
{
    [TestClass]
    public class UnitTest_PPGIPG
    {
        private readonly RHPsicotestDbContext dbContext;

        public UnitTest_PPGIPG()
        {
            var options = new DbContextOptionsBuilder<RHPsicotestDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            dbContext = new RHPsicotestDbContext(options);

            dbContext.Database.EnsureCreated();
        }

        private char[][] candidateResponse =
        {
            new char[] { 'A', 'B' }, // 1
            new char[] { 'A', 'B' }, // 2
            new char[] { 'A', 'B' }, // 3
            new char[] { 'A', 'B' }, // 4
            new char[] { 'A', 'B' }, // 5
            new char[] { 'A', 'B' }, // 6
            new char[] { 'A', 'B' }, // 7
            new char[] { 'A', 'B' }, // 8
            new char[] { 'A', 'B' }, // 9
            new char[] { 'A', 'B' }, // 10
            new char[] { 'A', 'B' }, // 11
            new char[] { 'A', 'B' }, // 12
            new char[] { 'A', 'B' }, // 13
            new char[] { 'A', 'B' }, // 14
            new char[] { 'A', 'B' }, // 15
            new char[] { 'A', 'B' }, // 16
            new char[] { 'A', 'B' }, // 17
            new char[] { 'A', 'B' }, // 18
            new char[] { 'A', 'B' }, // 19
            new char[] { 'A', 'B' }, // 20
            new char[] { 'A', 'B' }, // 21
            new char[] { 'A', 'B' }, // 22
            new char[] { 'A', 'B' }, // 23
            new char[] { 'A', 'B' }, // 24
            new char[] { 'A', 'B' }, // 25
            new char[] { 'A', 'B' }, // 26
            new char[] { 'A', 'B' }, // 27
            new char[] { 'A', 'B' }, // 28
            new char[] { 'A', 'B' }, // 29
            new char[] { 'A', 'B' }, // 30
            new char[] { 'A', 'B' }, // 31
            new char[] { 'A', 'B' }, // 32
            new char[] { 'A', 'B' }, // 33
            new char[] { 'A', 'B' }, // 34
            new char[] { 'A', 'B' }, // 35
            new char[] { 'A', 'B' }, // 36
            new char[] { 'A', 'B' }, // 37
            new char[] { 'A', 'B' }, // 38
        };


        [TestMethod]
        public async Task GeneratedResult_PPGIPG()
        {
            var repositoryTest = new TestRepository(dbContext);

            var result = await repositoryTest.GenerateResults_Test_PPGIPG(candidateResponse, 1);

            Assert.IsTrue(result);
        }
    }
}
