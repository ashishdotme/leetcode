using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Medium.DynamicProgramming
{
    internal class FrogJump
    {
        public int Answer( int[] n )
        {
            var dp = new int[n.Length];
            Array.Fill( dp, 0 );
            for ( int i = 1; i < n.Length; i++ )
            {
                var k1 = n[1 + i];
                var k2 = dp[i] + Math.Abs( n[i] )

            }
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [0, 1, 3, 5, 6, 8, 12, 17] );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
