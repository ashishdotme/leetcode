namespace Problems.Easy.DynamicProgramming
{
    public class DivisorGame
    {
        public bool Solution( int n )
        {
            return n % 2 == 0;
        }

        [TestCaseSource( nameof(DivisorGameTestCases) )]
        public void DivisorGameTest( (int data, bool expected) tc )
        {
            bool res = Solution( tc.data );
            Assert.That( res, Is.EqualTo( tc.expected ) );
        }

        public static IEnumerable<(int, bool)> DivisorGameTestCases()
        {
            yield return ( 2, true );
            yield return ( 3, false );
        }
    }
}