using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.Recursion
{
    internal class PrintAllSubsequence
    {
        public void Solution( int[] nums, List<int> result, int index )
        {
            if ( index == nums.Length )
            {
                TestContext.WriteLine( $"Output => {result.PrintList()}" );
                return;
            }
            Solution( nums, result , index + 1 );
            result.Add( nums[index] );

            Solution( nums, result, index + 1 );
            result.RemoveAt( result.Count - 1 );

        }

        [Test]
        public void ProblemTest()
        {
            Solution( [3, 2, 1], new (), 0 );
        }
    }
}
