using System.Collections.Generic;

namespace Algorithms
{
    public static partial class Algorithms
    {

		/// <summary>
        /// Retrieve the factors of n
        /// </summary>
        /// <param name="n">The number to derive factors from</param>
        /// <returns>Factors of n</returns>
		public static List<long> FactorsBruteForce(long n)
        {

            List<long> factors = new List<long>();

			for(long i = 1; i <= n; i++)
            {

				if(n % i == 0)
                {
                    factors.Add(i);
                }

            }

            return factors;

        }


        /// <summary>
        /// Retrieve the prime factors of n
        /// </summary>
        /// <param name="n">The number to derive prime factors from</param>
        /// <returns>Prime Factors of n</returns>
        public static List<ulong> PrimeFactors(ulong n)
        {

            List<ulong> primeFactors = new List<ulong>();

            List<ulong> primeNumbers = Algorithms.SieveOfEratosthenes(n);

            foreach(ulong primeNumber in primeNumbers)
            {

                if(n % primeNumber == 0)
                {
                    primeFactors.Add(primeNumber);
                }

            }

            return primeFactors;

        }

    }
}
