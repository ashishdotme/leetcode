using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Medium.Backtracking
{
    internal class Subsets2
    {
        public void Answer( int[] nums, IList<IList<int>> result, List<int>curr, int index )
        {
            result.Add( curr.ToArray() );
            for ( int i = index; i < nums.Length; i++ )
            {
                if ( i > index && nums[i] == nums[i-1] )
                {
                    continue;
                }
                curr.Add( nums[i] );
                Answer( nums, result, curr, i + 1 );
                curr.RemoveAt( curr.Count - 1 );
            }
        }

        [Test]
        public void ProblemTest()
        {
            var result = new List<IList<int>>();
            int[] nums = [1, 2, 2];
            Array.Sort( nums );
            Answer( nums, result, new List<int>(), 0 );
            result.Print();
        }
    }
}
