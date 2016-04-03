using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Algorithms.Tests
{
    
    public class MathGCFTests
    {

        [Theory]
        [InlineData(72,90,18)]
        public void TestGCF(long lhs, long rhs, long expectedResult)
        {

            long result = Math.GCF(lhs, rhs);

            Assert.Equal(expectedResult, result);

        }

    }
}
