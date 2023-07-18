using Microsoft.VisualStudio.TestTools.UnitTesting;
using RHPsicotest.UTB;
using System.Threading.Tasks;

namespace RHPsicotest.UT
{
    [TestClass]
    public class UnitTest_PPGIPG
    {
        TestResults test = new TestResults();

        // Default
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

        // Josue Saul 4
        private char[][] josue =
        {
            new char[] { 'C', 'D' }, // 1
            new char[] { 'B', 'D' }, // 2
            new char[] { 'D', 'A' }, // 3
            new char[] { 'D', 'C' }, // 4
            new char[] { 'D', 'C' }, // 5
            new char[] { 'A', 'B' }, // 6
            new char[] { 'B', 'D' }, // 7
            new char[] { 'C', 'D' }, // 8
            new char[] { 'C', 'D' }, // 9
            new char[] { 'A', 'B' }, // 10
            new char[] { 'B', 'C' }, // 11
            new char[] { 'D', 'A' }, // 12
            new char[] { 'D', 'A' }, // 13
            new char[] { 'A', 'C' }, // 14
            new char[] { 'D', 'C' }, // 15
            new char[] { 'A', 'D' }, // 16
            new char[] { 'A', 'C' }, // 17
            new char[] { 'A', 'B' }, // 18
            new char[] { 'D', 'C' }, // 19
            new char[] { 'B', 'D' }, // 20
            new char[] { 'A', 'D' }, // 21
            new char[] { 'A', 'D' }, // 22
            new char[] { 'C', 'D' }, // 23
            new char[] { 'C', 'B' }, // 24
            new char[] { 'A', 'C' }, // 25
            new char[] { 'C', 'B' }, // 26
            new char[] { 'D', 'A' }, // 27
            new char[] { 'B', 'C' }, // 28
            new char[] { 'A', 'B' }, // 29
            new char[] { 'C', 'A' }, // 30
            new char[] { 'D', 'A' }, // 31
            new char[] { 'D', 'A' }, // 32
            new char[] { 'B', 'C' }, // 33
            new char[] { 'B', 'D' }, // 34
            new char[] { 'C', 'D' }, // 35
            new char[] { 'D', 'C' }, // 36
            new char[] { 'D', 'C' }, // 37
            new char[] { 'C', 'D' }, // 38
        };

        // Jose David 5
        private char[][] jose =
        {
            new char[] { 'C', 'B' }, // 1
            new char[] { 'B', 'D' }, // 2
            new char[] { 'D', 'A' }, // 3
            new char[] { 'D', 'C' }, // 4
            new char[] { 'A', 'C' }, // 5
            new char[] { 'C', 'B' }, // 6
            new char[] { 'A', 'B' }, // 7
            new char[] { 'B', 'D' }, // 8
            new char[] { 'C', 'D' }, // 9
            new char[] { 'C', 'B' }, // 10
            new char[] { 'D', 'A' }, // 11
            new char[] { 'C', 'A' }, // 12
            new char[] { 'D', 'B' }, // 13
            new char[] { 'A', 'C' }, // 14
            new char[] { 'D', 'C' }, // 15
            new char[] { 'A', 'B' }, // 16
            new char[] { 'A', 'C' }, // 17
            new char[] { 'A', 'C' }, // 18
            new char[] { 'A', 'C' }, // 19
            new char[] { 'B', 'D' }, // 20
            new char[] { 'A', 'D' }, // 21
            new char[] { 'C', 'B' }, // 22
            new char[] { 'A', 'B' }, // 23
            new char[] { 'C', 'B' }, // 24
            new char[] { 'A', 'D' }, // 25
            new char[] { 'D', 'A' }, // 26
            new char[] { 'A', 'B' }, // 27
            new char[] { 'B', 'A' }, // 28
            new char[] { 'A', 'D' }, // 29
            new char[] { 'C', 'A' }, // 30
            new char[] { 'B', 'A' }, // 31
            new char[] { 'B', 'C' }, // 32
            new char[] { 'A', 'D' }, // 33
            new char[] { 'B', 'D' }, // 34
            new char[] { 'B', 'D' }, // 35
            new char[] { 'D', 'C' }, // 36
            new char[] { 'D', 'B' }, // 37
            new char[] { 'C', 'A' }, // 38
        };

        // Ever Misael 6
        private char[][] ever =
        {
            new char[] { 'B', 'A' }, // 1
            new char[] { 'A', 'D' }, // 2
            new char[] { 'D', 'B' }, // 3
            new char[] { 'A', 'C' }, // 4
            new char[] { 'A', 'C' }, // 5
            new char[] { 'C', 'D' }, // 6
            new char[] { 'D', 'C' }, // 7
            new char[] { 'B', 'A' }, // 8
            new char[] { 'C', 'A' }, // 9
            new char[] { 'A', 'D' }, // 10
            new char[] { 'D', 'C' }, // 11
            new char[] { 'C', 'D' }, // 12
            new char[] { 'A', 'D' }, // 13
            new char[] { 'A', 'C' }, // 14
            new char[] { 'A', 'C' }, // 15
            new char[] { 'A', 'D' }, // 16
            new char[] { 'C', 'D' }, // 17
            new char[] { 'C', 'B' }, // 18
            new char[] { 'D', 'A' }, // 19
            new char[] { 'B', 'D' }, // 20
            new char[] { 'A', 'D' }, // 21
            new char[] { 'A', 'D' }, // 22
            new char[] { 'A', 'D' }, // 23
            new char[] { 'C', 'D' }, // 24
            new char[] { 'A', 'B' }, // 25
            new char[] { 'C', 'B' }, // 26
            new char[] { 'D', 'A' }, // 27
            new char[] { 'B', 'C' }, // 28
            new char[] { 'A', 'D' }, // 29
            new char[] { 'C', 'D' }, // 30
            new char[] { 'C', 'D' }, // 31
            new char[] { 'B', 'C' }, // 32
            new char[] { 'A', 'B' }, // 33
            new char[] { 'B', 'D' }, // 34
            new char[] { 'C', 'D' }, // 35
            new char[] { 'A', 'C' }, // 36
            new char[] { 'A', 'C' }, // 37
            new char[] { 'B', 'D' }, // 38
        };

        // Adrian Alexander 7
        private char[][] adrian =
        {
            new char[] { 'B', 'A' }, // 1
            new char[] { 'D', 'A' }, // 2
            new char[] { 'D', 'C' }, // 3
            new char[] { 'D', 'C' }, // 4
            new char[] { 'D', 'C' }, // 5
            new char[] { 'A', 'B' }, // 6
            new char[] { 'B', 'D' }, // 7
            new char[] { 'C', 'D' }, // 8
            new char[] { 'C', 'B' }, // 9
            new char[] { 'B', 'A' }, // 10
            new char[] { 'A', 'B' }, // 11
            new char[] { 'D', 'B' }, // 12
            new char[] { 'D', 'C' }, // 13
            new char[] { 'A', 'B' }, // 14
            new char[] { 'A', 'C' }, // 15
            new char[] { 'A', 'C' }, // 16
            new char[] { 'A', 'B' }, // 17
            new char[] { 'D', 'C' }, // 18
            new char[] { 'C', 'A' }, // 19
            new char[] { 'A', 'D' }, // 20
            new char[] { 'C', 'B' }, // 21
            new char[] { 'C', 'B' }, // 22
            new char[] { 'C', 'B' }, // 23
            new char[] { 'C', 'B' }, // 24
            new char[] { 'A', 'C' }, // 25
            new char[] { 'C', 'A' }, // 26
            new char[] { 'A', 'B' }, // 27
            new char[] { 'B', 'A' }, // 28
            new char[] { 'A', 'B' }, // 29
            new char[] { 'C', 'A' }, // 30
            new char[] { 'C', 'A' }, // 31
            new char[] { 'D', 'C' }, // 32
            new char[] { 'B', 'D' }, // 33
            new char[] { 'B', 'C' }, // 34
            new char[] { 'B', 'D' }, // 35
            new char[] { 'C', 'D' }, // 36
            new char[] { 'D', 'C' }, // 37
            new char[] { 'C', 'D' }, // 38
        };

        // Carlos Alfredo 8
        private char[][] carlos =
        {
            new char[] { 'C', 'D' }, // 1
            new char[] { 'B', 'C' }, // 2
            new char[] { 'D', 'A' }, // 3
            new char[] { 'A', 'D' }, // 4
            new char[] { 'A', 'C' }, // 5
            new char[] { 'D', 'B' }, // 6
            new char[] { 'A', 'B' }, // 7
            new char[] { 'C', 'D' }, // 8
            new char[] { 'C', 'D' }, // 9
            new char[] { 'A', 'B' }, // 10
            new char[] { 'B', 'A' }, // 11
            new char[] { 'D', 'A' }, // 12
            new char[] { 'D', 'A' }, // 13
            new char[] { 'A', 'D' }, // 14
            new char[] { 'D', 'C' }, // 15
            new char[] { 'A', 'B' }, // 16
            new char[] { 'A', 'C' }, // 17
            new char[] { 'A', 'B' }, // 18
            new char[] { 'D', 'B' }, // 19
            new char[] { 'C', 'A' }, // 20
            new char[] { 'A', 'B' }, // 21
            new char[] { 'A', 'B' }, // 22
            new char[] { 'A', 'B' }, // 23
            new char[] { 'C', 'A' }, // 24
            new char[] { 'A', 'D' }, // 25
            new char[] { 'C', 'A' }, // 26
            new char[] { 'D', 'A' }, // 27
            new char[] { 'B', 'A' }, // 28
            new char[] { 'A', 'B' }, // 29
            new char[] { 'C', 'A' }, // 30
            new char[] { 'C', 'A' }, // 31
            new char[] { 'D', 'B' }, // 32
            new char[] { 'A', 'D' }, // 33
            new char[] { 'A', 'D' }, // 34
            new char[] { 'C', 'B' }, // 35
            new char[] { 'D', 'C' }, // 36
            new char[] { 'D', 'A' }, // 37
            new char[] { 'C', 'A' }, // 38
        };



        [TestMethod]
        public void GeneratedResult_PPGIPG()
        {
            var result = test.GenerateResults_Test_PPGIPG(carlos, 1);

            Assert.IsTrue(result);
        }
    }
}
