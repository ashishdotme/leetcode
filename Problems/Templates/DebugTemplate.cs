using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Templates
{
    internal class DebugTemplate
    {
        public int Answer( int[] nums )
        {
            return 1;
        }

        [Test]
        public void ProblemTest()
        {
            var result =  Answer( [2, 3] );
            TestContext.WriteLine( $"Output => {result}" );
        }
    }
}
