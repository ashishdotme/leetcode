using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.Recursion
{
    internal class CountNoOfSubsequenceWithSum
    {
        public int Solution( int[] nums, int target, List<int> result, int sum, int index )
        {
            if ( index == nums.Length )
            {
                if ( sum == target )
                {
                    result.Print();
                    return 1;
                }
                return 0;
            }
            result.Add( nums[index] );
            sum += nums[index];
            var l = Solution( nums, target, result, sum, index + 1 );
            result.RemoveAt( result.Count - 1 );
            sum -= nums[index];
            var r = Solution( nums, target, result, sum, index + 1 );
            return l + r;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Solution( [1,6,2,5,1,3], 5, new(), 0, 0 );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
