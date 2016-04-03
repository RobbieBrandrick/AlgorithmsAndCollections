using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static partial class Math
    {
		
		/// <summary>
        /// Find the greatest common factor of two numbers
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>The greatest common factor</returns>
		public static long GCF(long lhs, long rhs)
        {

            List<long> lhsCommonFactors = Math.Factors(lhs);
            List<long> rhsCommonFactors = Math.Factors(rhs);

            long gfc = 0;

            lhsCommonFactors.Sort();

            for(int i = lhsCommonFactors.Count - 1; i >= 0; i--)
            {

                if (rhsCommonFactors.Contains(lhsCommonFactors[i]))
                {
                    gfc = lhsCommonFactors[i];
                    break;
                }

            }

            return gfc;

        }
    }
}
