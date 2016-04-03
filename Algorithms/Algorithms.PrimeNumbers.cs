using System.Collections.Generic;
using System;

namespace Algorithms
{
    public static partial class Algorithms
    {

        /// <summary>
        /// Find all the prime numbers up to n.
        /// </summary>
        /// <param name="n">The number to find primes numbers up to</param>
        /// <returns>All prime numbers up to n</returns>
        /// <remarks>
        /// The Sieve of Eratosthenes is an ancient algorithm for finding all prime numbers
        /// up to any given limit (i.e., n).
        /// </remarks>
        public static List<ulong> SieveOfEratosthenes(ulong n)
        {

            if (n <= 1)
                throw new InvalidOperationException("n must be greater than 1");

            List<ulong> result = new List<ulong>();
            char[] sieve = new char[n];

            for(uint i = 2; i < n; i++)
            {

                if (sieve[i] == 'X')
                {
                    continue;
                }

                sieve[i] = 'P';
                result.Add(i);

                for(uint j = i + i; j < n; j += i)
                {
                    sieve[j] = 'X';
                }

            }
            

            return result;

        }

    }
}
