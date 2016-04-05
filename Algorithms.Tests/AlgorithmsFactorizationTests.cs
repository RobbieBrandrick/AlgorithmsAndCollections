using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class AlgorithmsFactorizationTests
    {

        public class FactorsBruteForce
        {

            [Fact]
            public void MustReturnTheFactorsOfTen()
            {

                List<long> expectedResult = new List<long>() { 1, 2, 5, 10 };
                List<long> actualResult = Algorithms.FactorsBruteForce(10);

                Assert.Equal(expectedResult, actualResult);

            }

        }

    }
}
