using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.Recursion
{
    public class PrintAllPermutations
    {
        public void Answer( int[] nums, List<IList<int>> result, List<int> curr, bool[] map )
        {
            if ( nums.Length == curr.Count )
            {
                curr.Print();
                result.Add( curr.ToArray() );
                return;
            }
            for ( int i = 0; i < nums.Length; i++ )
            {
                if (!map[i])
                {
                    map[i] = true;
                    curr.Add( nums[i] );
                    Answer( nums, result, curr, map );
                    map[i] = false;
                    curr.RemoveAt( curr.Count - 1 );
                }
            }
        }

        [Test]
        public void ProblemTest()
        {
            var result = new List<IList<int>>();
            int[] nums = [1, 2, 3];
            var map = new bool[nums.Length];
            Answer( nums , result, new List<int>() , map);
            result.Print();
        }
    }
}
