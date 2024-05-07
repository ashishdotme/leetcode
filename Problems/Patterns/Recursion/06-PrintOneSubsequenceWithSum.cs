using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.Recursion
{
    internal class PrintOneSubsequenceWithSum
    {
        public bool Solution( int[] nums, int target, List<int> result, int sum , int index )
        {
            if ( index == nums.Length )
            {
                if ( sum == target )
                {
                    result.Print();
                    return true;
                }

                return false;
            }

            result.Add( nums[index] );
            sum += nums[index];
            if ( Solution( nums, target, result, sum, index + 1 ) )
            {
                return true;
            }
            result.RemoveAt( result.Count  - 1 );
            sum -= nums[index];
            if ( Solution( nums, target, result, sum, index + 1 ) )
            {
                return true;
            }

            return false;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Solution( [1,2,1],2 , new(), 0 , 0);
            TestContext.WriteLine( result );
        }
    }
}
