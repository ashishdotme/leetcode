using System.Runtime.Intrinsics.Arm;

using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class MinCostClimbingStairs
    {

        public int Solution( int[] cost )
        {
            var dp = new int[cost.Length + 1];
            for(int i = 2; i <= cost.Length; i++){
                dp[i] = Math.Min( dp[i - 2] + cost[i - 2], dp[i - 1] + cost[i-1] );
            }
            return dp[cost.Length];
        }

        [TestCaseSource( nameof(MinCostClimbingStairsTestCases) )]
        public void MinCostClimbingStairsTest( (int[] data, int expected) tc )
        {
            int res = Solution( tc.data );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int[], int)> MinCostClimbingStairsTestCases()
        {
            yield return ( new int[] {10, 15, 20}, 15 );
        }
    }
}