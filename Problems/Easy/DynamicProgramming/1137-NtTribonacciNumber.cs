using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class NtTribonacciNumber
    {
        public int Solution( int n )
        {
            if(n == 0) {
                return 0;
            }
            if(n == 1 || n ==2){
                return 1;
            }
            var dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;
            for(int i = 3;i < n + 1; i++){
                dp[i] = dp[i - 3] + dp[i - 2] + dp[i - 1];
                dp.Print();
            }
            return dp[n];
        }

        // [1, 1, 2, 3, 5, 8]
        [TestCaseSource( nameof( NthTribonacciNumberTestCases ) )]
        public void NthTribonacciNumberTest( (int data, int expected) tc )
        {
            int res = Solution( tc.data );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, int)> NthTribonacciNumberTestCases()
        {
            yield return (25, 1389537);
        }
    }
}