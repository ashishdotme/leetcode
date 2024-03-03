using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class ClimbStairs
    {
        public int[] dp;
        public int Recursion(int n, int[] dp){
            if(n == 1 || n == 2){
                return n;
            }

            dp.Print();

            if(dp[n] != 0) {
                return dp[n];
            }

            dp[n] = Recursion( n - 1, dp ) + Recursion( n - 2, dp );

            dp.Print();
            return dp[n];
        }
        public int Solution( int n )
        {
            dp = new int[n + 1];
            var result = Recursion( n, dp );
            return result;
        }

        [TestCaseSource( nameof( ClimbStairsTestCases ) )]
        public void ClimbStairsTest( (int n, int expected) tc )
        {
            int res = Solution( tc.n );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, int)> ClimbStairsTestCases()
        {
            yield return (3,3);
        }
    }
}