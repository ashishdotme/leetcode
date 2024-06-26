﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Given an array of integers nums, return the number of good pairs.

    A pair (i, j) is called good if nums[i] == nums[j] and i<j.

    Example 1:

Input: nums = [1, 2, 3, 1, 1, 3]
Output: 4
Explanation: There are 4 good pairs(0,3), (0, 4), (3, 4), (2, 5) 0 - indexed.
    Example 2:

Input: nums = [1, 1, 1, 1]
Output: 6
Explanation: Each pair in the array are good.
    Example 3:

Input: nums = [1, 2, 3]
Output: 0*/


namespace Problems.Easy.Arrays
{
    internal class NumberOfGoodPairs
    {
        public int Answer( int[] nums )
        {
            var counter = 0;
            for ( int i = 0; i < nums.Length; i++ )
            {
                for ( int j = i + 1; j < nums.Length; j++ )
                {
                    if ( nums[i] == nums[j])
                    {
                        counter += 1;
                    }
                }
            }

            return counter;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [1, 1, 1, 1] );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
