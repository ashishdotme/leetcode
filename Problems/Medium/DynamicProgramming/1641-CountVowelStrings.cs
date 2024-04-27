using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Medium.DynamicProgramming
{
    public class CountVowelStrings
    {
        public int Solution( int n )
        {
            var result = Recursion( n, 0 );
            int Recursion( int n, int index )
            {
                if ( n == 0 )
                {
                    return 1;
                }

                var count = 0;
                for ( int i = index; i < 5; i++ )
                {
                    count += Recursion( n - 1, i );
                }
                return count;
            }

            return result;
        }

        [TestCaseSource( nameof( CountVowelStringsTestCases ) )]
        public void CountVowelStringsTest( (int n, int expected) tc )
        {
            var res = Solution( tc.n );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, int)> CountVowelStringsTestCases()
        {
            yield return (1, 5);
            yield return (2, 15);
        }
    }
}
