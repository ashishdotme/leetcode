namespace Problems.Easy.Arrays
{
    internal class RangeSumQuery
    {
        [Test]
        public void ProblemTest()
        {
            NumArray temp = new NumArray( [2, 3] );
        }

        public class NumArray
        {
            private readonly int[] _value;

            public NumArray( int[] nums )
            {
                _value = nums;
            }

            public int SumRange( int left, int right )
            {
                int sum = 0;
                for ( int i = left; i < right; i++ )
                {
                    sum += _value[i];
                }

                return sum;
            }
        }
    }
}