﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;


/*
There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

Note that multiple kids can have the greatest number of candies.

 

    Example 1:

Input: candies = [2, 3, 5, 1, 3], extraCandies = 3
Output: [true,true,true,false,true] 
Explanation: If you give all extraCandies to:
-Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
    Example 2:

Input: candies = [4, 2, 1, 1, 2], extraCandies = 1
Output: [true,false,false,false,false] 
Explanation: There is only 1 extra candy.
    Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
    Example 3:

Input: candies = [12, 1, 12], extraCandies = 10
Output: [true,false,true]*/

namespace Problems.Easy.Arrays
{
    internal class KidsWithGreatestNumberOfCandies
    {
        public bool[] Answer( int[] candies, int extraCandies )
        {
            var maxCandies = candies[0];
            var result = new List<bool>();
            for ( int i = 0; i < candies.Length; i++ )
            {
                if ( candies[i] > maxCandies )
                {
                    maxCandies = candies[i];
                }
            }

            for ( int i = 0; i < candies.Length; i++ )
            {
                if ( candies[i] + extraCandies >= maxCandies )
                {
                    result.Add( true );
                }
                else
                {
                    result.Add( false );
                }
            }
            return result.ToArray();
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [2, 3, 5, 1, 3], 3 );
            TestContext.WriteLine( $"Output => {result.PrintList()}" );
        }
    }
}
