using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class PascalTriangle2
    {
        public IList<int> Solution( int rowIndex )
        {
            var dp = new List<IList<int>>();
            dp.Insert(0, new List<int> { 1 });
            dp.Insert(1, new List<int> { 1, 1 });

            for (int i = 1; i < rowIndex; i++){
                var temp = new List<int> { 1 };
                for(int j = 0; j < dp[dp.Count - 1].Count - 1; j++){
                    temp.Add( dp[i][j] + dp[i][j + 1] );
                }
                temp.Add( 1 );
                dp.Add( temp );
            }
            return dp[rowIndex];
        }

        [TestCaseSource( nameof( PascalTriangle2TestCases ) )]
        public void PascalTriangle2Test( (int data, IList<int> expected) tc )
        {
            IList<int> res = Solution( tc.data );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, IList<int>)> PascalTriangle2TestCases()
        {
            yield return (3,
                new List<int> { 1, 3, 3, 1 });
        }
    }
}