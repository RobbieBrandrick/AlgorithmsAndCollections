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

        public class PrimeFactors
        {

            [Fact]
            public void MustReturnThePrimeFactorsOfTen()
            {

                List<ulong> expectedResult = new List<ulong>() {2, 5};
                List<ulong> actualResult = Algorithms.PrimeFactors(10);

                Assert.Equal(expectedResult, actualResult);

            }

            [Fact]
            public void MustReturnThePrimeFactorsOfOneHundred()
            {

                List<ulong> expectedResult = new List<ulong>() { 2, 5 };
                List<ulong> actualResult = Algorithms.PrimeFactors(100);

                Assert.Equal(expectedResult, actualResult);

            }

            [Fact]
            public void MustReturnThePrimeFactorsOfFiftyTwo()
            {

                List<ulong> expectedResult = new List<ulong>() { 2, 13 };
                List<ulong> actualResult = Algorithms.PrimeFactors(52);

                Assert.Equal(expectedResult, actualResult);

            }

            [Fact]
            public void MustReturnThePrimeFactorsOfFiftyNine()
            {

                List<ulong> expectedResult = new List<ulong>() { 59 };
                List<ulong> actualResult = Algorithms.PrimeFactors(59);

                Assert.Equal(expectedResult, actualResult);

            }

        }


    }
}
