using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.Arrays
{
    internal class ConcatenationOfArray
    {
        public void Answer( int[] nums, List<int> result, int index )
        {
            if ( result.Count == 2 * nums.Length )
            {
                return;
            }

            if ( index == nums.Length )
            {
                index = 0;
            }
            result.Add( nums[index] );
            Answer( nums, result, index + 1);
        }

        [Test]
        public void ProblemTest()
        {
            var result = new List<int>();
             Answer( [1, 2, 1], result, 0 );
            result.Print();
        }
    }
}
