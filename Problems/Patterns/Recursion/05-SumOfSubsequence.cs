using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.Recursion
{
    internal class SumOfSubsequence
    {
        public void Solution( int[] nums, int target, List<int> result, int sum, int index)
        {
            if ( index == nums.Length )
            {
                if ( sum == target )
                {
                    TestContext.WriteLine( $"Output => {result.PrintList()}" );
                }
                return;
            }
            result.Add( nums[index] );
            sum += nums[index];
            Solution( nums, target, result, sum, index + 1 );
            result.RemoveAt( result.Count - 1 );
            sum -= nums[index];
            Solution( nums, target, result, sum, index + 1 );
        }

        [Test]
        public void ProblemTest()
        {
            Solution( [1, 2, 1], 2, new (), 0, 0 );
            
        }
    }
}
