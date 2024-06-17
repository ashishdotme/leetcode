using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Medium.Backtracking
{
    internal class CombinationSum2
    {
        public void Solution( int[] candidates, int target,  IList<IList<int>> result, List<int>curr, int index, int sum)
        {
            if ( target == 0 )
            {
                result.Add( curr.ToArray() );
                return;

            }

            for ( int i = index; i < candidates.Length; i++ )
            {
                if ( i > index && candidates[i] == candidates[i - 1] )
                {
                    continue;
                }
                if ( candidates[i] > target )
                {
                    break;
                }
                curr.Add( candidates[i] );
                Solution( candidates, target - candidates[i], result, curr, i + 1, sum );
                curr.RemoveAt( curr.Count - 1 );
            }
        }

        [Test]
        public void ProblemTest()
        {
            IList<IList<int>> result = new List<IList<int>>();
            var candidates = new int[] { 2, 5, 2, 1, 2 };
            Array.Sort( candidates );
            Solution( candidates,5, result, new List<int>(), 0, 0 );

            result.Print();
        }
    }
}
