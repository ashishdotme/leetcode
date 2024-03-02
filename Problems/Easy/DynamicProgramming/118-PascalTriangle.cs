using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NUnit.Framework;

using Problems.Common;
namespace Problems.Easy.DynamicProgramming
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate( int numRows )
        {
            if(numRows == 1){
                return [[1]];
            }
            var result = new List<IList<int>>() { new List<int> { 1 }, new List<int> { 1, 1 } };
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

        [TestCaseSource( nameof( TestCases ) )]
        public void PascalTriangleTest( (int numRows, IList<IList<int>> expected) td )
        {
            var res = Generate( td.numRows );
            Assert.That( res, Is.EqualTo( td.expected ) );
        }
        public static IEnumerable<(int, IList<IList<int>>)> TestCases()
        {
            yield return (5, new List<IList<int>>() { new List<int>() { 1 }, new List<int>() { 1, 1 }, new List<int>() { 1, 2, 1 }, new List<int>() { 1, 3, 3, 1 }, new List<int>() { 1, 4, 6, 4, 1 } });
        }
    }
}