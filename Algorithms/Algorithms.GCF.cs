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
        /// <remarks>
        /// This routine is using Euclids Algorithm
        /// </remarks>
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

                //E1[Find remainder] let r be the remainder of lhs / rhs
                ulong r = lhs % rhs;

                //E2[Is it zero?] if r = 0, the algorithm terminates, rhs is the answer
                if (r == 0)
                    return rhs;

                //E3[Reduce] Set rhs <- lhs, lhs <- r, and go back to setp E1
                lhs = rhs;
                rhs = r;

            }
            
        }
    }
}
