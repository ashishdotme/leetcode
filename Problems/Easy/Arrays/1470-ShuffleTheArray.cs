using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;

using Problems.Common;

/*Given the array nums consisting of 2n elements in the form [x1, x2, ..., xn, y1, y2, ..., yn].

Return the array in the form [x1, y1, x2, y2, ..., xn, yn].



Example 1:

Input: nums = [2, 5, 1, 3, 4, 7], n = 3
Output: [2,3,5,4,1,7] 
Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2, 3, 5, 4, 1, 7].
Example 2:

Input: nums = [1, 2, 3, 4, 4, 3, 2, 1], n = 4
Output: [1,4,2,3,3,2,4,1]
Example 3:

Input: nums = [1, 1, 2, 2], n = 2
Output: [1,2,1,2]*/

namespace Problems.Easy.Arrays
{
    internal class ShuffleTheArray
    {
        public int[] Answer( int[] nums, int n )
        {
            var left = 0;
            var right = n;
            var index = 0;
            var result = new int[nums.Length];
            while ( index < nums.Length && left <= n && right < nums.Length)
            {
                if ( index % 2 == 0 )
                {
                    result[index] = nums[left];
                    left += 1;
                }
                else
                {
                    result[index] = nums[right];
                    right += 1;
                }
                index += 1;
            }
            return result;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [2, 5, 1, 3, 4, 7],3 );
            //output -  [2,3,5,4,1,7] 
            TestContext.WriteLine( $"Output => {result.PrintList()}" );
        }
    }
}
