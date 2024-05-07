using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Templates
{
    internal class DebugTemplate
    {
        public int Solution( int[] nums )
        {
            return 1;
        }

        [Test]
        public void ProblemTest()
        {
            var result =  Solution( [2, 3] );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
