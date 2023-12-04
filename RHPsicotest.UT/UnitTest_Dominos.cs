using Microsoft.VisualStudio.TestTools.UnitTesting;
using RHPsicotest.UTB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHPsicotest.UT
{
    [TestClass]
    public class UnitTest_Dominos
    {
        TestResults test = new TestResults();

        int testId = 3;

        // Josue 
        char?[][] josue =
        {
            new char?[] { '2', '2' }, // 1
            new char?[] { '3', '5' }, // 2
            new char?[] { '0', '0' }, // 3
            new char?[] { '2', '4' }, // 4
            new char?[] { '5', '5' }, // 5
            new char?[] { '1', '1' }, // 6
            new char?[] { '2', '3' }, // 7
            new char?[] { '6', '4' }, // 8
            new char?[] { '4', '2' }, // 9
            new char?[] { '4', '4' }, // 10
            new char?[] { '4', '0' }, // 11
            new char?[] { '0', '0' }, // 12
            new char?[] { '3', '4' }, // 13
            new char?[] { '4', '2' }, // 14
            new char?[] { '6', '4' }, // 15
            new char?[] { '6', '2' }, // 16
            new char?[] { '5', '4' }, // 17
            new char?[] { '3', '4' }, // 18
            new char?[] { '2', '3' }, // 19
            new char?[] { '3', '5' }, // 20
            new char?[] { '6', '5' }, // 21
            new char?[] { '5', '3' }, // 22
            new char?[] { '4', '2' }, // 23
            new char?[] { '2', '1' }, // 24
            new char?[] { '0', '0' }, // 25
            new char?[] { '5', '3' }, // 26
            new char?[] { '0', '0' }, // 27
            new char?[] { '0', '0' }, // 28
            new char?[] { '0', '0' }, // 29
            new char?[] { '6', '0' }, // 30
            new char?[] { '3', '2' }, // 31
            new char?[] { '4', '5' }, // 32
            new char?[] { '6', '1' }, // 33
            new char?[] { '6', '1' }, // 34
            new char?[] { '0', '0' }, // 35
            new char?[] { '1', '2' }, // 36
            new char?[] { '0', '0' }, // 37
            new char?[] { '2', '3' }, // 38
            new char?[] { '6', '6' }, // 39
            new char?[] { '2', '0' }, // 40
            new char?[] { '1', '2' }, // 41
            new char?[] { '2', '6' }, // 42
            new char?[] { '0', '0' }, // 43
            new char?[] { '0', '0' }, // 44
        };

        // Jose  
        char?[][] jose =
        {
            new char?[] { '2', '2' }, // 1
            new char?[] { '3', '5' }, // 2
            new char?[] { '3', '1' }, // 3
            new char?[] { '4', '2' }, // 4
            new char?[] { '5', '5' }, // 5
            new char?[] { '1', '1' }, // 6
            new char?[] { '4', '1' }, // 7
            new char?[] { '5', '3' }, // 8
            new char?[] { '2', '2' }, // 9
            new char?[] { '4', '4' }, // 10
            new char?[] { '4', '0' }, // 11
            new char?[] { '3', '2' }, // 12
            new char?[] { '3', '4' }, // 13
            new char?[] { '4', '2' }, // 14
            new char?[] { '4', '6' }, // 15
            new char?[] { '6', '2' }, // 16
            new char?[] { '3', '2' }, // 17
            new char?[] { '1', '1' }, // 18
            new char?[] { '3', '2' }, // 19
            new char?[] { '5', '3' }, // 20
            new char?[] { '5', '6' }, // 21
            new char?[] { '6', '1' }, // 22
            new char?[] { '2', '4' }, // 23
            new char?[] { '2', '4' }, // 24
            new char?[] { '5', '2' }, // 25
            new char?[] { '5', '3' }, // 26
            new char?[] { '6', '5' }, // 27
            new char?[] { '4', '2' }, // 28
            new char?[] { '1', '1' }, // 29
            new char?[] { '6', '6' }, // 30
            new char?[] { '3', '5' }, // 31
            new char?[] { '5', '3' }, // 32
            new char?[] { '6', '1' }, // 33
            new char?[] { '3', '0' }, // 34
            new char?[] { '6', '2' }, // 35
            new char?[] { '2', '1' }, // 36
            new char?[] { '1', '5' }, // 37
            new char?[] { '5', '3' }, // 38
            new char?[] { '4', '6' }, // 39
            new char?[] { '2', '0' }, // 40
            new char?[] { '3', '2' }, // 41
            new char?[] { '4', '4' }, // 42
            new char?[] { '2', '2' }, // 43
            new char?[] { '5', '2' }, // 44
        };

        // Ever 
        char?[][] ever =
        {
            new char?[] { '2', '2' }, // 1
            new char?[] { '3', '5' }, // 2
            new char?[] { '3', '1' }, // 3
            new char?[] { '4', '2' }, // 4
            new char?[] { '5', '5' }, // 5
            new char?[] { '1', '1' }, // 6
            new char?[] { '4', '1' }, // 7
            new char?[] { '6', '4' }, // 8
            new char?[] { '4', '2' }, // 9
            new char?[] { '0', '0' }, // 10
            new char?[] { '2', '1' }, // 11
            new char?[] { '3', '2' }, // 12
            new char?[] { '3', '4' }, // 13
            new char?[] { '4', '2' }, // 14
            new char?[] { '6', '4' }, // 15
            new char?[] { '6', '2' }, // 16
            new char?[] { '0', '4' }, // 17
            new char?[] { '0', '0' }, // 18
            new char?[] { '1', '1' }, // 19
            new char?[] { '4', '3' }, // 20
            new char?[] { '6', '4' }, // 21
            new char?[] { '2', '1' }, // 22
            new char?[] { '2', '6' }, // 23
            new char?[] { '1', '4' }, // 24
            new char?[] { '6', '1' }, // 25
            new char?[] { '5', '3' }, // 26
            new char?[] { '6', '1' }, // 27
            new char?[] { '5', '4' }, // 28
            new char?[] { '2', '1' }, // 29
            new char?[] { '0', '0' }, // 30
            new char?[] { '3', '0' }, // 31
            new char?[] { '2', '1' }, // 32
            new char?[] { '5', '5' }, // 33
            new char?[] { '3', '1' }, // 34
            new char?[] { '0', '3' }, // 35
            new char?[] { '0', '2' }, // 36
            new char?[] { '4', '3' }, // 37
            new char?[] { '4', '5' }, // 38
            new char?[] { '5', '3' }, // 39
            new char?[] { '1', '6' }, // 40
            new char?[] { '1', '3' }, // 41
            new char?[] { '5', '5' }, // 42
            new char?[] { '4', '4' }, // 43
            new char?[] { '3', '6' }, // 44
        };

        // Adrian 
        char?[][] adrian =
        {
            new char?[] { '2', '2' }, // 1
            new char?[] { '3', '5' }, // 2
            new char?[] { '3', '1' }, // 3
            new char?[] { '4', '2' }, // 4
            new char?[] { '5', '5' }, // 5
            new char?[] { '1', '1' }, // 6
            new char?[] { '4', '2' }, // 7
            new char?[] { '6', '4' }, // 8
            new char?[] { '4', '2' }, // 9
            new char?[] { '4', '4' }, // 10
            new char?[] { '4', '0' }, // 11
            new char?[] { '3', '2' }, // 12
            new char?[] { '3', '4' }, // 13
            new char?[] { '2', '4' }, // 14
            new char?[] { '4', '6' }, // 15
            new char?[] { '2', '6' }, // 16
            new char?[] { '4', '0' }, // 17
            new char?[] { '4', '3' }, // 18
            new char?[] { '3', '2' }, // 19
            new char?[] { '5', '3' }, // 20
            new char?[] { '5', '6' }, // 21
            new char?[] { '3', '5' }, // 22
            new char?[] { '2', '4' }, // 23
            new char?[] { '1', '1' }, // 24
            new char?[] { '0', '4' }, // 25
            new char?[] { '3', '5' }, // 26
            new char?[] { '6', '0' }, // 27
            new char?[] { '4', '3' }, // 28
            new char?[] { '0', '2' }, // 29
            new char?[] { '0', '6' }, // 30
            new char?[] { '3', '0' }, // 31
            new char?[] { '6', '0' }, // 32
            new char?[] { '6', '1' }, // 33
            new char?[] { '6', '3' }, // 34
            new char?[] { '2', '0' }, // 35
            new char?[] { '1', '2' }, // 36
            new char?[] { '4', '0' }, // 37
            new char?[] { '4', '3' }, // 38
            new char?[] { '2', '6' }, // 39
            new char?[] { '6', '0' }, // 40
            new char?[] { '1', '3' }, // 41
            new char?[] { '3', '3' }, // 42
            new char?[] { '6', '6' }, // 43
            new char?[] { '0', '0' }, // 44
        };

        // Carlos 
        char?[][] carlos =
        {
            new char?[] { '2', '2' }, // 1
            new char?[] { '3', '5' }, // 2
            new char?[] { '3', '1' }, // 3
            new char?[] { '4', '2' }, // 4
            new char?[] { '5', '5' }, // 5
            new char?[] { '1', '1' }, // 6
            new char?[] { '4', '1' }, // 7
            new char?[] { '6', '4' }, // 8
            new char?[] { '4', '2' }, // 9
            new char?[] { '4', '4' }, // 10
            new char?[] { '4', '0' }, // 11
            new char?[] { '3', '2' }, // 12
            new char?[] { '3', '4' }, // 13
            new char?[] { '2', '4' }, // 14
            new char?[] { '4', '6' }, // 15
            new char?[] { '2', '4' }, // 16
            new char?[] { '4', '5' }, // 17
            new char?[] { '4', '3' }, // 18
            new char?[] { '3', '2' }, // 19
            new char?[] { '5', '3' }, // 20
            new char?[] { '5', '6' }, // 21
            new char?[] { '3', '3' }, // 22
            new char?[] { '2', '4' }, // 23
            new char?[] { '2', '4' }, // 24
            new char?[] { '2', '2' }, // 25
            new char?[] { '5', '3' }, // 26
            new char?[] { '6', '0' }, // 27
            new char?[] { '4', '3' }, // 28
            new char?[] { '0', '2' }, // 29
            new char?[] { '0', '6' }, // 30
            new char?[] { '3', '0' }, // 31
            new char?[] { '0', '1' }, // 32
            new char?[] { '6', '1' }, // 33
            new char?[] { '3', '0' }, // 34
            new char?[] { '6', '4' }, // 35
            new char?[] { '2', '1' }, // 36
            new char?[] { '5', '5' }, // 37
            new char?[] { '3', '4' }, // 38
            new char?[] { '6', '6' }, // 39
            new char?[] { '6', '0' }, // 40
            new char?[] { '2', '6' }, // 41
            new char?[] { '6', '6' }, // 42
            new char?[] { '2', '5' }, // 43
            new char?[] { '3', '4' }, // 44
        };



        [TestMethod]
        public void GeneratedResult_Domino()
        {
            //var result = test.GenerateResults_Test_Dominos(josue, 4);
            //var result1 = test.GenerateResults_Test_Dominos(jose, 5);
            //var result2 = test.GenerateResults_Test_Dominos(ever, 6);
            //var result3 = test.GenerateResults_Test_Dominos(adrian, 7);
            //var result4 = test.GenerateResults_Test_Dominos(carlos, 8);

            //Assert.IsTrue(result);
            //Assert.IsTrue(result1);
            //Assert.IsTrue(result2);
            //Assert.IsTrue(result3);
            //Assert.IsTrue(result4);
        }
    }
}
