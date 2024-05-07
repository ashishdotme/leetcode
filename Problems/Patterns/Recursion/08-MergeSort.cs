using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Problems.Common;

namespace Problems.Patterns.Recursion
{
    internal class MergeSort
    {
        public void Solution( int[] arr, int low, int high )
        {
            var mid = ( low + high ) / 2;
            if ( low == high )
            {
                return;
            }
            Solution( arr, low, mid );
            Solution(arr, mid + 1, high  );
            Merge( arr, low, mid, high );
        }

        private void Merge( int[] arr, int low, int mid, int high )
        {
            var temp = new List<int>();
            var left = low;
            var right = mid + 1;
            while ( left <= mid && right <= high )
            {
                if ( arr[left] <= arr[right] )
                {
                    temp.Add( arr[left] );
                    left += 1;

                }
                else
                {
                    temp.Add( arr[right] );
                    right += 1;
                }
            }

            while ( left <= mid )
            {
                temp.Add( arr[left] );
                left += 1;
            }

            while ( right <= high )
            {
                temp.Add( arr[right] );
                right += 1;
            }

            for ( int i = low; i <= high; i++ )
            {
                arr[i] = temp[i - low];
            }
        }

        [Test]
        public void ProblemTest()
        {
            var arr = new int[]{3, 1, 2, 4, 1, 5, 2, 6, 4};
            Solution(arr , 0 , arr.Length - 1 );
            arr.Print();
        }
    }
}
