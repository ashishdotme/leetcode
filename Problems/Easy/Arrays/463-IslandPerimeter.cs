using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.Arrays
{
    public class IslandPerimeter
    {
        public int Answer( int[,] matrix )
        {
            var rows = matrix.GetLength( 0 );
            var cols = matrix.GetLength( 1 );
            var area = 0;
            for ( int i = 0; i < rows; i++ )
            {
                for ( int j = 0; j < cols; j++ )
                {
                    if ( matrix[i,j] == 1 )
                    {
                        area += 4;
                    }
                }
            }
            TestContext.WriteLine( $"Output => \n{matrix.ToMatrixString()}, {rows}, {cols}" );
            return area;
        }

        [Test]
        public void ProblemTest()
        {
            int[,] matrix = {
                {0, 1, 0, 0},
                {1,1,1,0},
                {0,1,0,0},
                {1,1,0,0},
            };
            var result = Answer( matrix );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}

/*Input: grid = [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]
Output: 16
Explanation: The perimeter is the 16 yellow stripes in the image above.*/