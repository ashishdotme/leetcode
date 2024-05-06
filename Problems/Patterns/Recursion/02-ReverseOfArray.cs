using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Patterns.Recursion
{
    public class ReverseOfArray
    {
        public int[] Solution( int[] nums, int left, int right )
        {
            if ( left >= right )
            {
                return nums;
            }

            var temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            return Solution( nums, left + 1, right - 1 );
        }

        public int[] Solution2( int[] nums, int index)
        {
            if ( index >= nums.Length/2 )
            {
                return nums;
            }

            var temp = nums[index];
            nums[index] = nums[nums.Length - index - 1];
            nums[nums.Length - index - 1] = temp;

            return Solution2( nums, index + 1 );
        }

        [TestCase( new[] { 3, 2, 4, 5, 6 }, ExpectedResult = new[] { 6, 5, 4, 2, 3} )]
        public int[] ProblemTest( int[] nums)
        {
            return Solution2( nums, 0 );
        }
    }
}
