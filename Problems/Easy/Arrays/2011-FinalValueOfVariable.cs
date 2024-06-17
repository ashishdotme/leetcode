using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*There is a programming language with only four operations and one variable X:

++X and X++ increments the value of the variable X by 1.
    --X and X-- decrements the value of the variable X by 1.
    Initially, the value of X is 0.

    Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.

 

    Example 1:

Input: operations = ["--X", "X++", "X++"]
Output: 1
Explanation: The operations are performed as follows:
Initially, X = 0.
    --X: X is decremented by 1, X = 0 - 1 = -1.
    X++: X is incremented by 1, X = -1 + 1 = 0.
    X++: X is incremented by 1, X = 0 + 1 = 1.
    Example 2:

Input: operations = ["++X", "++X", "X++"]
Output: 3
Explanation: The operations are performed as follows:
Initially, X = 0.
    ++X: X is incremented by 1, X = 0 + 1 = 1.
    ++X: X is incremented by 1, X = 1 + 1 = 2.
    X++: X is incremented by 1, X = 2 + 1 = 3.
    Example 3:

Input: operations = ["X++", "++X", "--X", "X--"]
Output: 0
Explanation: The operations are performed as follows:
Initially, X = 0.
    X++: X is incremented by 1, X = 0 + 1 = 1.
    ++X: X is incremented by 1, X = 1 + 1 = 2.
    --X: X is decremented by 1, X = 2 - 1 = 1.
    X--: X is decremented by 1, X = 1 - 1 = 0.*/

namespace Problems.Easy.Arrays
{
    internal class FinalValueOfVariable
    {
        public int Answer( string[] nums )
        {
            var counter = 0;
            for ( int i = 0; i < nums.Length; i++ )
            {
                if ( nums[i] == "--X" )
                {
                    counter -= 1;
                }
                else
                {
                    counter += 1;
                }
            }
            return counter;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( ["--X", "X++", "X++"] );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
