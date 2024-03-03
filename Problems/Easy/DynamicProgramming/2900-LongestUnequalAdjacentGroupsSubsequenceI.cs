using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.Easy.DynamicProgramming
{
    public class LongestUnequalAdjacentGroupsSubsequenceI
    {
        public IList<string> Solution( string[] words, int[] groups )
        {
            IList<string> result = [words[0]];

            for(int i = 1; i < groups.Length;  i++){
                if(groups[i] != groups[i-1]){
                    result.Add( words[i] );
                }
            }

            return result;
        }

        [TestCaseSource( nameof( LongestSubsequenceTestCases ) )]
        public void LongestSubsequenceTest( (string[] words, int[] groups, IList<string> expected) tc )
        {
            var res = Solution( tc.words, tc.groups );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(string[], int[], IList<string>)> LongestSubsequenceTestCases()
        {
            yield return (["e", "a", "b"], [0, 0, 1], ["e", "b"]);
        }
    }
}