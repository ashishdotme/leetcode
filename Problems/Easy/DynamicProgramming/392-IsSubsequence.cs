using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class IsSubsequence
    {
        public bool Recursion( string s, string t, int sIndex, int tIndex )
        {
            if ( s.Length == sIndex )
            {
                return true;
            }
            if ( tIndex == t.Length )
            {
                return false;
            }
            if ( s[sIndex] == t[tIndex] )
            {
                return Recursion( s, t, sIndex + 1, tIndex + 1 );
            }
            else
            {
                return Recursion( s, t, sIndex, tIndex + 1 );
            }
        }
        public bool Solution( string s, string t )
        {
            var result = Recursion( s, t, 0, 0 );
            return result;
        }

        [TestCaseSource( nameof( IsSubsequenceTestCases ) )]
        public void IsSubsequenceTest( (string s, string t, bool expected) tc )
        {
            bool res = Solution( tc.s, tc.t );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(string, string, bool)> IsSubsequenceTestCases()
        {
            yield return ("abc", "ahbgdc", true);
        }
    }
}