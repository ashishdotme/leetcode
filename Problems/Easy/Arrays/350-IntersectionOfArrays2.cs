using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Easy.Arrays
{
    public class IntersectionOfArrays2
    {
        public int[] Answer( int[] nums1, int[] nums2 )
        {
            Hashtable map = new Hashtable();

            for ( int i = 0; i < nums1.Length; i++ )
            {
                if (!map.Contains( nums1[i] ) )
                {
                    map.Add( nums1[i], 1 );
                }
                else
                {
                    map[nums1[i]] = (int) map[nums1[i]] + 1;
                }
            }

            var result = new List<int>();
            for ( int i = 0; i < nums2.Length; i++ )
            {
                if ( map.Contains( nums2[i] ) )
                {
                    map[nums2[i]] = (int)map[nums2[i]] - 1;
                    if ((int) map[nums2[i]] >= 0)
                    {
                        result.Add( nums2[i] );
                    }
                }
            }
            return result.ToArray();

        }

        [Test]
        public void ProblemTest()
        {
            var result = Answer( [4,4, 9, 5], [9, 4, 9, 8, 4] );
            TestContext.WriteLine( $"Output => {result.PrintList()}" );
        }
    }
}
