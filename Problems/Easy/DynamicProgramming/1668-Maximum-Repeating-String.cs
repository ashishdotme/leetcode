using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*For a string sequence, a string word is k-repeating if word concatenated k times is a substring of sequence.
 The word's maximum k-repeating value is the highest value k where word is k-repeating in sequence. 
If word is not a substring of sequence, word's maximum k-repeating value is 0.

    Given strings sequence and word, return the maximum k-repeating value of word in sequence.

 

    Example 1:

Input: sequence = "ababc", word = "ab"
Output: 2
Explanation: "abab" is a substring in "ababc".
    Example 2:

Input: sequence = "ababc", word = "ba"
Output: 1
Explanation: "ba" is a substring in "ababc". "baba" is not a substring in "ababc".
    Example 3:

Input: sequence = "ababc", word = "ac"
Output: 0
Explanation: "ac" is not a substring in "ababc".


    Constraints:

1 <= sequence.length <= 100
1 <= word.length <= 100
sequence and word contains only lowercase English letters.*/


namespace Problems.Easy.DynamicProgramming
{
    public class MaximumRepeatingString
    {
        public int Solution( string sequence, string word )
        {
            int count = 0;
            string orig = word;

            while ( word.Length <= sequence.Length )
            {
                if ( sequence.Contains( word ) )
                {
                    count += 1;
                }
                else
                {
                    break;
                }

                word += orig;
            }
            return count;
        }

        [TestCaseSource( nameof( LongestSubsequenceTestCases ) )]
        public void LongestSubsequenceTest( (string sequence, string word, int expected) tc )
        {
            var res = Solution( tc.sequence, tc.word );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(string, string, int)> LongestSubsequenceTestCases()
        {
            yield return ("ababc", "ab", 2);
        }
    }
}
