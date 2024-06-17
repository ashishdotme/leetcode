using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Example 1:

You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.
   
Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).
   
The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island. One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.
   
    
*/

namespace Problems.Easy.Arrays
{
    public class AssignCookies
    {
        public int Answer( int[] g, int[] s)
        {
            Array.Sort( s );
            Array.Sort( g );

            var i = 0;
            var j = 0;
            var result = 0;
            while ( i < g.Length && j < s.Length )
            {
                if ( g[i] <= s[j] )
                {
                    result++;
                    i++;
                }
                j++;
            }
            return result;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [10, 9, 8, 7], [5, 6, 7, 8] );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}

/*g =
    [10, 9, 8, 7] // [7,8,9,10]
s =
    [5, 6, 7, 8]
*/