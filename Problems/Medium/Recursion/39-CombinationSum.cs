using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Medium.Recursion
{
    internal class CombinationSum
    {
        public List<List<int>> Solution( int[] candidates, int target, List<List<int>> result, int index )
        {
            
            return result;
        }

        [Test]
        public void ProblemTest()
        {
            var result = Solution( [2, 3, 6 ,7], 7, new List<List<int>>(), 0 );
            result.Print();
        }
    }
}
