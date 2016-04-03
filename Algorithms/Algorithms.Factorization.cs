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
		public static List<long> Factors(long n)
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

    }
}
