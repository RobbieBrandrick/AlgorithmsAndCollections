using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static partial class Algorithms
    {
		
		/// <summary>
        /// Find the greatest common factor of two numbers
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>The greatest common factor</returns>
		public static ulong GCF(ulong lhs, ulong rhs)
        {

            if (lhs <= 1 || rhs <= 1)
                throw new InvalidOperationException("paramters must be greater than 1");

            while (true)
            {

                //E0[swap] if lhs < rhs
                if (lhs < rhs)
                {
                    lhs = lhs ^ rhs;
                    rhs = lhs ^ rhs;
                    lhs = lhs ^ rhs;
                }

                ulong r = lhs % rhs;

                if (r == 0)
                    return rhs;

                lhs = rhs;
                rhs = r;
            }
            
        }
    }
}
