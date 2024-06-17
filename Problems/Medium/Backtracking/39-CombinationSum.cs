using Problems.Common;

namespace Problems.Medium.Backtracking
{
    internal class CombinationSum
    {
        

        public void Solution( int[] candidates, int target, List<int> temp,  int index, IList<IList<int>> result )
        {
            if ( index == candidates.Length )
            {
                if (target == 0)
                {
                    var list = temp;
                    result.Add( list.ToArray());
                }
                return;
            }
            if ( candidates[index] <= target )
            {
                temp.Add( candidates[index] );
                Solution( candidates, target - candidates[index], temp, index, result );
                temp.RemoveAt( temp.Count - 1 );
            }
            Solution( candidates, target, temp, index + 1, result);
        }

        [Test]
        public void ProblemTest()
        {
            IList<IList<int>> result = new List<IList<int>>();
            Solution( [2, 3, 6 ,7], 7, new (),0, result );
            result.Print();
        }
    }
}
