using NUnit.Framework;

using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class FibonacciNumber
    {
        public int Fib( int n )
        {
            if ( n == 0 )
            {
                return 0;
            }

            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for ( int i = 2; i < n + 1; i++ )
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            dp.Print();
            return dp[n];
        }

        // [1, 1, 2, 3, 5, 8]
        [TestCaseSource( nameof(FibonacciNumberTestCases) )]
        public void FibonacciNumberTest( (int numRows, int expected) tc )
        {
            int res = Fib( tc.numRows );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, int)> FibonacciNumberTestCases()
        {
            yield return ( 2, 1 );
            yield return ( 3, 2 );
            yield return ( 4, 3 );
            yield return ( 5, 5 );
            yield return ( 6, 8 );
        }
    }
}