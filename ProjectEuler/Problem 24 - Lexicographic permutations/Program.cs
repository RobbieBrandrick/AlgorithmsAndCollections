/*
A permutation is an ordered arrangement of objects.For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.The lexicographic 
permutations of 0, 1 and 2 are:

012   021   102   120   201   210

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

REFERENCE: https://en.wikipedia.org/wiki/Permutation#Generation_in_lexicographic_order
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_24___Lexicographic_permutations
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, int[]> permutations = new Dictionary<int, int[]>();
            int count = 0;
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = a.Length;
            int k;
            int l;

            while (true)
            {

                count++;
                permutations.Add(count, a.ToArray());

                //1. Find the largest index k such that a[k] < a[k + 1].If no such index exists, the permutation is the last permutation.
                for (k = n - 2; k >= 0 && a[k] > a[k + 1]; k--) { }

                if (k == -1)
                    break;

                //2. Find the largest index l greater than k such that a[k] < a[l].
                for (l = n - 1; l > k && a[k] > a[l]; l--) { }

                //3. Swap the value of a[k] with that of a[l].
                Swap(ref a[k], ref a[l]);

                //4. Reverse the sequence from a[k + 1] up to and including the final element a[n].
                int len = n - 1;
                int kk = k + 1;
                while(len > kk)
                {
                    Swap(ref a[kk], ref a[len]);
                    kk++;
                    len--;
                }

            }

            //Print answer
            int[] answer = permutations[1000000];

            foreach(int i in answer)
            {
                Console.Write(i + ", ");
            }

        }

        /// <summary>
        /// Swaps int references from the lhs to the rhs using exclusive or swap
        /// </summary>
        private static void Swap(ref int lhs, ref int rhs)
        {
            lhs = rhs ^ lhs;
            rhs = rhs ^ lhs;
            lhs = rhs ^ lhs;
        }

    }
}
