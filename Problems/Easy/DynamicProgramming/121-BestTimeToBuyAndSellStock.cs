using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.Easy.DynamicProgramming
{
    public class BestTimeToBuyAndSellStock
    {
        public int Solution( int[] prices )
        {
            var result = 0;
            var minPrice = prices[0];
            for ( int i = 1; i < prices.Length; i++ )
            {
                if(prices[i] < minPrice){
                    minPrice = prices[i];
                } else {
                    result = Math.Max( result, prices[i] - minPrice);
                }
            }
            return result;
        }

        [TestCaseSource( nameof( BestTimeToBuyAndSellStockTestCases ) )]
        public void BestTimeToBuyAndSellStockTest( (int[] data, int expected) tc )
        {
            int res = Solution( tc.data );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int[], int)> BestTimeToBuyAndSellStockTestCases()
        {
            yield return ([7, 1, 5, 3, 6, 4], 5);
        }
    }
}