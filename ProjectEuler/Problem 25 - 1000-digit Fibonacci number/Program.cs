/*
The Fibonacci sequence is defined by the recurrence relation:

Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
Hence the first 12 terms will be:

F1 = 1
F2 = 1
F3 = 2
F4 = 3
F5 = 5
F6 = 8
F7 = 13
F8 = 21
F9 = 34
F10 = 55
F11 = 89
F12 = 144
The 12th term, F12, is the first term to contain three digits.

What is the index of the first term in the Fibonacci sequence to contain 1000 digits? 4782
*/

using System;
using System.Numerics;
using System.Diagnostics;

namespace Problem_25___1000_digit_Fibonacci_number
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger max = BigInteger.Pow(10, 999);
            BigInteger i = 0;
            BigInteger answer = 0;

            Stopwatch solutionStopWatch = Stopwatch.StartNew();
            solutionStopWatch.Start();
            do
            {
                i++;

                Stopwatch fibStopWatch = Stopwatch.StartNew();

                fibStopWatch.Start();
                answer = Fibonacci(i);
                fibStopWatch.Stop();
                long elapsedFibTime = fibStopWatch.ElapsedTicks;

                //Console.WriteLine("F{0}:{1} in {2} ticks", i, answer, elapsedTime);

            } while (answer < max);

            solutionStopWatch.Stop();
            long elapsedSolutionTime = solutionStopWatch.ElapsedTicks;

            Console.WriteLine("F{0}:{1} in {2} ticks", i, answer, elapsedSolutionTime);

        }

        private static BigInteger Fibonacci(BigInteger n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;

            BigInteger result = 0;
            BigInteger previous = 1;
            BigInteger previousPrevious = 0;

            for(int i = 2; i <= n; i++)
            {
                result = previous + previousPrevious;
                previousPrevious = previous;
                previous = result;
            }

            return result;

        }
    }
}
