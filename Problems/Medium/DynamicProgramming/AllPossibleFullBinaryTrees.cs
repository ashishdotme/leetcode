using System.Diagnostics;

using Problems.Common;

namespace Problems.Medium.DynamicProgramming
{
    public class AllPossibleFullBinaryTrees
    {
        private readonly List<List<TreeNode>> _dp = new();

        public List<TreeNode> Solution( int n )
        {
            for ( var i = 0; i <= n; i++ )
            {
                _dp.Add( new List<TreeNode>() );
            }

            return solve( n );
        }

        private List<TreeNode> solve( int n )
        {
            if ( n % 2 == 0 )
            {
                return new List<TreeNode>();
            }

            if ( _dp[n].Any() )
            {
                return _dp[n];
            }

            if ( n == 1 )
            {
                var node = new TreeNode( 0 );
                var result = new List<TreeNode>() { node};
                return result;
            }

            var res = new List<TreeNode>();

            for ( int i = 0; i < n; i++ )
            {
                var leftNodes = solve( i );
                var rightNodes = solve( n - i - 1 );

                foreach ( TreeNode left in leftNodes )
                {
                    foreach ( TreeNode right in rightNodes )
                    {

                        var root = new TreeNode( 0 );
                        root.left = left;
                        root.right = right;
                        res.Add( root );

                    }
                }
            }

            return _dp[n] = res;
        }
    

        [TestCaseSource( nameof( AllPossibleFullBinaryTreesCases ) )]
        public void AllPossibleFullBinaryTreesTest( (int data, List<TreeNode> expected) tc )
        {
            List<TreeNode> res = Solution( tc.data );
            res.First().PrintPretty( " ", NodePosition.center, true, false);
            Assert.That( res.Count, Is.EqualTo( tc.expected.Count ) );
        }

        public static IEnumerable<(int, List<TreeNode>)> AllPossibleFullBinaryTreesCases()
        {
            var bt = new TreeNode(0);
            bt.left = new TreeNode( 0 );
            bt.right = new TreeNode( 0 );
            yield return (3, new List<TreeNode>() {bt});
        }
    }
}