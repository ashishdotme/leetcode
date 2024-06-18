using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Patterns.DynamicProgramming._1D
{
    public class ClimbingStairs
    {
        public int Answer( int stairs )
        {
            var dp = new int[stairs];
            Array.Fill(dp, 0);
            dp[0] = 1;
            dp[1] = 2;
            for ( int i = 2; i < stairs; i++ )
            {
                dp[i] = dp[i - 2] + dp[i - 1];
            }

            return dp[stairs - 1];
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( 3 );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
