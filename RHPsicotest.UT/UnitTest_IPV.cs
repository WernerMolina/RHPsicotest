﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RHPsicotest.UTB;
using System.Threading.Tasks;

namespace RHPsicotest.UT
{
    [TestClass]
    public class UnitTest_IPV
    {
        TestResults test = new TestResults();
        int testId = 7;
	
	// 4 19 11 4-5-4-6 3-3-3-2 4
	char[] werndy =
        {
            'A', // 1
            'A', // 2
            'A', // 3
            'B', // 4
            'C', // 5
            'A', // 6
            'B', // 7
            'C', // 8
            'A', // 9
            'C', // 10
            'C', // 11
            'B', // 12
            'B', // 13
            'B', // 14
            'C', // 15
            'A', // 16
            'C', // 17
            'C', // 18
            'A', // 19
            'B', // 20
            'A', // 21
            'C', // 22
            'C', // 23
            'A', // 24
            'A', // 25
            'A', // 26
            'B', // 27
            'A', // 28
            'B', // 29
            'C', // 30
            'B', // 31
            'A', // 32
            'B', // 33
            'B', // 34
            'A', // 35
            'B', // 36
            'B', // 37
            'B', // 38
            'B', // 39
            'C', // 40
            'A', // 41
            'A', // 42
            'C', // 43
            'C', // 44
            'C', // 45
            'B', // 46
            'B', // 47
            'A', // 48
            'C', // 49
            'C', // 50
            'A', // 51
            'B', // 52
            'A', // 53
            'A', // 54
            'B', // 55
            'A', // 56
            'A', // 57
            'C', // 58
            'B', // 59
            'B', // 60
            'B', // 61
            'A', // 62
            'A', // 63
            'A', // 64
            'C', // 65
            'B', // 66
            'C', // 67
            'B', // 68
            'A', // 69
            'A', // 70
            'B', // 71
            'A', // 72
            'B', // 73
            'A', // 74
            'B', // 75
            'A', // 76
            'A', // 77
            'B', // 78
            'C', // 79
            'A', // 80
            'A', // 81
            'B', // 82
            'A', // 83
            'B', // 84
            'B', // 85
            'A', // 86
            'B', // 87
        };

        char[] carlos =
        {
            'B', // 1
            'B', // 2
            'B', // 3
            'A', // 4
            'A', // 5
            'A', // 6
            'B', // 7
            'C', // 8
            'C', // 9
            'C', // 10
            'B', // 11
            'A', // 12
            'B', // 13
            'A', // 14
            'C', // 15
            'C', // 16
            'B', // 17
            'C', // 18
            'C', // 19
            'A', // 20
            'C', // 21
            'A', // 22
            'B', // 23
            'B', // 24
            'C', // 25
            'A', // 26
            'C', // 27
            'A', // 28
            'A', // 29
            'C', // 30
            'A', // 31
            'A', // 32
            'A', // 33
            'B', // 34
            'A', // 35
            'C', // 36
            'B', // 37
            'A', // 38
            'B', // 39
            'A', // 40
            'A', // 41
            'A', // 42
            'B', // 43
            'B', // 44
            'A', // 45
            'A', // 46
            'A', // 47
            'C', // 48
            'B', // 49
            'C', // 50
            'A', // 51
            'B', // 52
            'A', // 53
            'A', // 54
            'A', // 55
            'A', // 56
            'C', // 57
            'C', // 58
            'A', // 59
            'B', // 60
            'C', // 61
            'A', // 62
            'B', // 63
            'A', // 64
            'A', // 65
            'B', // 66
            'C', // 67
            'A', // 68
            'A', // 69
            'A', // 70
            'A', // 71
            'C', // 72
            'C', // 73
            'A', // 74
            'B', // 75
            'A', // 76
            'B', // 77
            'B', // 78
            'C', // 79
            'B', // 80
            'A', // 81
            'B', // 82
            'A', // 83
            'B', // 84
            'A', // 85
            'A', // 86
            'C', // 87
        };

        char[] lemus =
        {
            'B', // 1
            'B', // 2
            'C', // 3
            'B', // 4
            'C', // 5
            'A', // 6
            'B', // 7
            'C', // 8
            'C', // 9
            'B', // 10
            'C', // 11
            'C', // 12
            'B', // 13
            'A', // 14
            'B', // 15
            'C', // 16
            'B', // 17
            'C', // 18
            'A', // 19
            'B', // 20
            'A', // 21
            'C', // 22
            'C', // 23
            'B', // 24
            'A', // 25
            'C', // 26
            'A', // 27
            'C', // 28
            'B', // 29
            'C', // 30
            'B', // 31
            'A', // 32
            'B', // 33
            'A', // 34
            'A', // 35
            'C', // 36
            'B', // 37
            'A', // 38
            'B', // 39
            'A', // 40
            'A', // 41
            'B', // 42
            'B', // 43
            'B', // 44
            'C', // 45
            'A', // 46
            'A', // 47
            'B', // 48
            'C', // 49
            'C', // 50
            'B', // 51
            'C', // 52
            'A', // 53
            'A', // 54
            'B', // 55
            'B', // 56
            'C', // 57
            'B', // 58
            'A', // 59
            'A', // 60
            'C', // 61
            'C', // 62
            'B', // 63
            'B', // 64
            'B', // 65
            'C', // 66
            'C', // 67
            'C', // 68
            'B', // 69
            'B', // 70
            'B', // 71
            'A', // 72
            'B', // 73
            'B', // 74
            'C', // 75
            'C', // 76
            'A', // 77
            'B', // 78
            'B', // 79
            'C', // 80
            'C', // 81
            'B', // 82
            'B', // 83
            'B', // 84
            'A', // 85
            'A', // 86
            'B', // 87
        };

        // error en la suma de resistencia es 11 no 16
        char[] edwin =
        {
            'B', // 1
            'A', // 2
            'A', // 3
            'B', // 4
            'B', // 5
            'A', // 6
            'A', // 7
            'C', // 8
            'A', // 9
            'C', // 10
            'C', // 11
            'A', // 12
            'B', // 13
            'B', // 14
            'B', // 15
            'A', // 16
            'C', // 17
            'A', // 18
            'A', // 19
            'B', // 20
            'A', // 21
            'A', // 22
            'B', // 23
            'B', // 24
            'A', // 25
            'A', // 26
            'B', // 27
            'A', // 28
            'A', // 29
            'C', // 30
            'B', // 31
            'B', // 32
            'A', // 33
            'A', // 34
            'A', // 35
            'C', // 36
            'C', // 37
            'C', // 38
            'B', // 39
            'C', // 40
            'A', // 41
            'A', // 42
            'C', // 43
            'C', // 44
            'C', // 45
            'B', // 46
            'A', // 47
            'B', // 48
            'A', // 49
            'C', // 50
            'A', // 51
            'A', // 52
            'B', // 53
            'A', // 54
            'B', // 55
            'B', // 56
            'C', // 57
            'A', // 58
            'B', // 59
            'A', // 60
            'C', // 61
            'B', // 62
            'A', // 63
            'C', // 64
            'B', // 65
            'C', // 66
            'C', // 67
            'B', // 68
            'C', // 69
            'C', // 70
            'A', // 71
            'A', // 72
            'B', // 73
            'A', // 74
            'B', // 75
            'C', // 76
            'C', // 77
            'B', // 78
            'C', // 79
            'C', // 80
            'A', // 81
            'C', // 82
            'A', // 83
            'A', // 84
            'C', // 85
            'C', // 86
            'B', // 87
        };

        // error en la resta de iv es 6 no 7
        char[] camila =
        {
            'B', // 1
            'B', // 2
            'C', // 3
            'B', // 4
            'A', // 5
            'C', // 6
            'B', // 7
            'B', // 8
            'C', // 9
            'B', // 10
            'B', // 11
            'B', // 12
            'B', // 13
            'B', // 14
            'B', // 15
            'C', // 16
            'B', // 17
            'A', // 18
            'C', // 19
            'B', // 20
            'C', // 21
            'C', // 22
            'C', // 23
            'A', // 24
            'B', // 25
            'A', // 26
            'A', // 27
            'C', // 28
            'C', // 29
            'C', // 30
            'A', // 31
            'B', // 32
            'C', // 33
            'B', // 34
            'B', // 35
            'C', // 36
            'C', // 37
            'A', // 38
            'A', // 39
            'C', // 40
            'A', // 41
            'B', // 42
            'C', // 43
            'C', // 44
            'C', // 45
            'B', // 46
            'C', // 47
            'B', // 48
            'C', // 49
            'A', // 50
            'A', // 51
            'C', // 52
            'B', // 53
            'A', // 54
            'B', // 55
            'A', // 56
            'C', // 57
            'B', // 58
            'B', // 59
            'A', // 60
            'A', // 61
            'B', // 62
            'B', // 63
            'A', // 64
            'B', // 65
            'A', // 66
            'B', // 67
            'B', // 68
            'A', // 69
            'B', // 70
            'A', // 71
            'A', // 72
            'B', // 73
            'B', // 74
            'C', // 75
            'C', // 76
            'B', // 77
            'B', // 78
            'A', // 79
            'C', // 80
            'B', // 81
            'C', // 82
            'A', // 83
            'A', // 84
            'A', // 85
            'B', // 86
            'A', // 87
        };

        // error en la suma de resistencia es 9 no 14
        char[] yael =
        {
            'C', // 1
            'A', // 2
            'B', // 3
            'B', // 4
            'A', // 5
            'A', // 6
            'B', // 7
            'C', // 8
            'A', // 9
            'C', // 10
            'B', // 11
            'C', // 12
            'C', // 13
            'A', // 14
            'B', // 15
            'C', // 16
            'C', // 17
            'A', // 18
            'C', // 19
            'B', // 20
            'C', // 21
            'C', // 22
            'B', // 23
            'B', // 24
            'C', // 25
            'A', // 26
            'B', // 27
            'B', // 28
            'A', // 29
            'C', // 30
            'B', // 31
            'A', // 32
            'C', // 33
            'C', // 34
            'A', // 35
            'C', // 36
            'C', // 37
            'A', // 38
            'A', // 39
            'A', // 40
            'C', // 41
            'A', // 42
            'C', // 43
            'C', // 44
            'C', // 45
            'A', // 46
            'A', // 47
            'B', // 48
            'C', // 49
            'C', // 50
            'A', // 51
            'A', // 52
            'A', // 53
            'A', // 54
            'B', // 55
            'C', // 56
            'C', // 57
            'C', // 58
            'B', // 59
            'A', // 60
            'C', // 61
            'A', // 62
            'B', // 63
            'B', // 64
            'B', // 65
            'B', // 66
            'B', // 67
            'B', // 68
            'C', // 69
            'A', // 70
            'A', // 71
            'A', // 72
            'A', // 73
            'A', // 74
            'C', // 75
            'C', // 76
            'C', // 77
            'B', // 78
            'C', // 79
            'A', // 80
            'C', // 81
            'A', // 82
            'A', // 83
            'B', // 84
            'C', // 85
            'C', // 86
            'B', // 87
        };

        char[] marta =
        {
            'B', // 1
            'B', // 2
            'A', // 3
            'B', // 4
            'A', // 5
            'A', // 6
            'A', // 7
            'C', // 8
            'C', // 9
            'C', // 10
            'A', // 11
            'B', // 12
            'B', // 13
            'B', // 14
            'B', // 15
            'C', // 16
            'B', // 17
            'A', // 18
            'A', // 19
            'B', // 20
            'C', // 21
            'A', // 22
            'B', // 23
            'B', // 24
            'C', // 25
            'A', // 26
            'C', // 27
            'C', // 28
            'A', // 29
            'C', // 30
            'B', // 31
            'B', // 32
            'C', // 33
            'A', // 34
            'B', // 35
            'C', // 36
            'B', // 37
            'C', // 38
            'A', // 39
            'C', // 40
            'B', // 41
            'B', // 42
            'C', // 43
            'B', // 44
            'C', // 45
            'A', // 46
            'C', // 47
            'A', // 48
            'B', // 49
            'C', // 50
            'C', // 51
            'C', // 52
            'C', // 53
            'B', // 54
            'B', // 55
            'A', // 56
            'C', // 57
            'C', // 58
            'A', // 59
            'A', // 60
            'C', // 61
            'C', // 62
            'A', // 63
            'B', // 64
            'C', // 65
            'B', // 66
            'C', // 67
            'B', // 68
            'A', // 69
            'A', // 70
            'B', // 71
            'A', // 72
            'C', // 73
            'A', // 74
            'C', // 75
            'A', // 76
            'B', // 77
            'B', // 78
            'C', // 79
            'C', // 80
            'C', // 81
            'C', // 82
            'A', // 83
            'A', // 84
            'A', // 85
            'C', // 86
            'A', // 87
        };

        char[] alexander =
        {
            'A', // 1
            'B', // 2
            'B', // 3
            'B', // 4
            'A', // 5
            'C', // 6
            'A', // 7
            'C', // 8
            'A', // 9
            'B', // 10
            'C', // 11
            'B', // 12
            'B', // 13
            'A', // 14
            'C', // 15
            'A', // 16
            'B', // 17
            'C', // 18
            'C', // 19
            'B', // 20
            'C', // 21
            'C', // 22
            'B', // 23
            'A', // 24
            'C', // 25
            'A', // 26
            'A', // 27
            'C', // 28
            'B', // 29
            'A', // 30
            'C', // 31
            'A', // 32
            'A', // 33
            'B', // 34
            'A', // 35
            'C', // 36
            'B', // 37
            'A', // 38
            'B', // 39
            'C', // 40
            'B', // 41
            'B', // 42
            'A', // 43
            'B', // 44
            'C', // 45
            'A', // 46
            'B', // 47
            'B', // 48
            'A', // 49
            'C', // 50
            'A', // 51
            'C', // 52
            'A', // 53
            'B', // 54
            'C', // 55
            'A', // 56
            'A', // 57
            'B', // 58
            'A', // 59
            'C', // 60
            'C', // 61
            'C', // 62
            'B', // 63
            'A', // 64
            'C', // 65
            'C', // 66
            'A', // 67
            'B', // 68
            'A', // 69
            'A', // 70
            'B', // 71
            'A', // 72
            'B', // 73
            'B', // 74
            'C', // 75
            'A', // 76
            'A', // 77
            'B', // 78
            'A', // 79
            'B', // 80
            'A', // 81
            'B', // 82
            'B', // 83
            'A', // 84
            'C', // 85
            'A', // 86
            'B', // 87
        };


        [TestMethod]
        public async Task GeneratedResult_IPV()
        {
            var result = await test.GenerateResults_Test_IPV(alexander, 8, testId);

            Assert.IsTrue(result);
        }
    }
}