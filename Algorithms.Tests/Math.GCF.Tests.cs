using Xunit;

namespace Algorithms.Tests
{
    
    public class MathGCFTests
    {

        [Theory]
        [InlineData(72,90,18)]
        [InlineData(5, 10, 5)]
        [InlineData(1, 1, 1)]
        [InlineData(63, 81, 9)]
        public void TestGCF(long lhs, long rhs, long expectedResult)
        {

            long result = Math.GCF(lhs, rhs);

            Assert.Equal(expectedResult, result);

        }

    }
}
