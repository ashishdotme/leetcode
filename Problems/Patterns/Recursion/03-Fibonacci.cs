using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Patterns.Recursion
{
    internal class Fibonacci
    {
         public int Solution( int n, int[] arr, int index )
        {
            if ( index > n )
            {
                return arr[n];
            }

            arr[index] = arr[index - 1] + arr[index - 2];
            return Solution( n, arr, index + 1 ) ;
        }

        [TestCase( 4, ExpectedResult = 3 )]
        public int ProblemTest( int n )
        {
            var arr = new int[n + 1];
            Array.Fill( arr, 0 );
            arr[0] = 0;
            arr[1] = 1;
            return Solution( n, arr, 2 );
        }
    }
}
