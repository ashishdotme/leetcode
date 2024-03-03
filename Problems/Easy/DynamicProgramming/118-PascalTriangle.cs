using Problems.Common;

namespace Problems.Easy.DynamicProgramming
{
    public class PascalTriangle
    {
        public IList<IList<int>> Solution( int numRows )
        {
            if ( numRows == 1 )
            {
                return [[1]];
            }

            List<IList<int>> result = new() { new List<int> { 1 }, new List<int> { 1, 1 } };
            for ( int i = 2; i < numRows; i++ )
            {
                List<int> temp = [1];
                for ( int j = 0; j < result[result.Count - 1].Count - 1; j++ )
                {
                    temp.Add( result[result.Count - 1][j] + result[result.Count - 1][j + 1] );
                }

                temp.Add( 1 );
                result.Add( temp );
            }

            result.Print();
            return result;
        }

        [TestCaseSource( nameof(PascalTriangleTestCases) )]
        public void PascalTriangleTest( (int data, IList<IList<int>> expected) tc )
        {
            IList<IList<int>> res = Solution( tc.data );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, IList<IList<int>>)> PascalTriangleTestCases()
        {
            yield return ( 5,
                new List<IList<int>>
                {
                    new List<int> { 1 },
                    new List<int> { 1, 1 },
                    new List<int> { 1, 2, 1 },
                    new List<int> { 1, 3, 3, 1 },
                    new List<int>
                    {
                        1,
                        4,
                        6,
                        4,
                        1
                    }
                } );
        }
    }
}