using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.DynamicProgramming.MinMax
{
    public class MinPathSum
    {

        public int Solution( int[][] grid )
        {
            var n = grid.Length;
            var m = grid[0].Length;

            var dp = new int[n,m];

            for ( int i = 1; i < n; i++ )
            {
                for ( int j = 1; j < m; j++ )
                {
                    dp[i,j] = 0;
                }
            }

            for ( int i = 0 ; i < n; i++ )
            {
                for ( int j = 0; j < m; j++ )
                {
                    dp[i, j] = Math.Min( dp[i, j], grid[i][j + 1] );
                }
            }

            Console.Out.WriteLine( dp.ToMatrixString( ) );
/*          for ( int j = 0; j < ways.size(); ++j )
            {
                if ( ways[j] <= i )
                {
                    dp[i] = min( dp[i], dp[i - ways[j]] + cost / path / sum );
                }
            }*/

            return 2;
        }

        [TestCaseSource( nameof( MinPathSumTestCases ) )]
        public void MinPathSumTest( (int[][] grid, int expected) tc )
        {
            var res = Solution( tc.grid );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int[][], int)> MinPathSumTestCases()
        {
            yield return ([[1, 3, 1], [1, 5, 1], [4, 2, 1]], 7);
        }
    }

}
