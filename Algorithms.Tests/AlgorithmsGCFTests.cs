using System;
using Xunit;
using Algorithms;
namespace Algorithms.Tests
{
    
    public class AlgorithmsGCFTests
    {

        [Theory]
        [InlineData(72,90,18)]
        [InlineData(5, 10, 5)]
        [InlineData(63, 81, 9)]
        [InlineData(49, 14, 7)]
        public void TestGCF(long lhs, long rhs, long expectedResult)
        {

            long result = Algorithms.GCF(lhs, rhs);
            
            Assert.Equal(expectedResult, result);

        }

        public void MustThrowWhenParametersAreNotGreaterThanOne()
        {

            Assert.Throws<InvalidOperationException>(() => Algorithms.GCF(1, 1));
            Assert.Throws<InvalidOperationException>(() => Algorithms.GCF(1, 10));
            Assert.Throws<InvalidOperationException>(() => Algorithms.GCF(10, 1));
            Assert.Throws<InvalidOperationException>(() => Algorithms.GCF(-1, -10));

        }

    }
}
