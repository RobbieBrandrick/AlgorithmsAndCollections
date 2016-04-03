using System.Collections.Generic;
using System;

namespace Algorithms
{
    public static partial class Algorithms
    {

        public static List<ulong> SieveOfEratosthenes(ulong n)
        {

            if (n <= 1)
                throw new InvalidOperationException("n must be greater than 1");

            char[] sieve = new char[n];

            for(uint i = 2; i < n; i++)
            {

                if (sieve[i] == 'X')
                {
                    continue;
                }

                sieve[i] = 'P';

                for(uint j = i + i; j < n; j += i)
                {
                    sieve[j] = 'X';
                }

            }

            List<ulong> result = new List<ulong>();

            for (uint i = 2; i < n; i++)
            {

                if(sieve[i] == 'P')
                {
                    result.Add(i);
                }

            }

            return result;

        }

    }
}
