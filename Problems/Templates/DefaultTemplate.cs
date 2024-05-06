using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Templates
{
    public class DefaultTemplate
    {
        public int[] Solution( int[] nums, int target )
        {
            Dictionary<int, int> dict = new();
            for ( int i = 0; i < nums.Length; i++ )
            {
                int val = 0;
                if ( dict.TryGetValue( target - nums[i], out val ) && val != i )
                {
                    Console.WriteLine( $"{i}, {val}" );
                    return [val, i];
                }

                dict.TryAdd( nums[i], i );
            }

            return [];
        }

        [TestCase( new[] { 3, 2, 4 }, 6, ExpectedResult = new[] { 1, 2 } )]
        [TestCase( new[] { 2, 7, 11, 15 }, 9, ExpectedResult = new[] { 0, 1 } )]
        public int[] ProblemTest( int[] nums, int target )
        {
            return Solution( nums, target );
        }
    }
}
