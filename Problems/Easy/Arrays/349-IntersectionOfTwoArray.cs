using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.Arrays
{
    internal class IntersectionOfTwoArray
    {
        public int[] Answer( int[] nums1, int[] nums2 )
        {
            HashSet<int> map = new HashSet<int>();
            List<int> intersection = new();
            for ( int i = 0; i < nums1.Length; i++ )
            {
                map.Add( nums1[i] );
            }

            for ( int i = 0; i < nums2.Length; i++ )
            {
                if ( map.Contains( nums2[i] ) )
                {
                    map.Remove( nums2[i] );
                    intersection.Add( nums2[i] );
                }
            }

            return intersection.ToArray();
        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [4, 9, 5], [9, 4, 9, 8, 4] );
            TestContext.WriteLine( $"Output => {result.PrintList()}" );
        }
    }
}


//nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]