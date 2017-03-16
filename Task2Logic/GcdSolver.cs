using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    
    public static class GcdSolver
    {
        #region Methods
       
        /// <summary>
        /// Euklid Gcd function with time measure
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd(a,b)</returns>
        public static Tuple<int,double> EuklidGcdWithTimeMeasure(int a, int b)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int gcd= EuklidGcd(a, b);
            clock.Stop();
            return Tuple.Create<int, double>(gcd, clock.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// Overloaded Euklid Gcd function with multiple arguments
        /// & time measure
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>gcd(params int[])</returns>
        public static Tuple<int, double> EuklidGcdWithTimeMeasure(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Not enough parameters");
            }

            Stopwatch clock = new Stopwatch();
            clock.Start();
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result=EuklidGcd(result, numbers[i]);
            }
            clock.Stop();
            return Tuple.Create<int, double>(result, clock.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// Binary gcd function with time measure
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd(a,b)</returns>
        public static Tuple<int, double> SteinGcdWithTimeMeasure(int a, int b)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int gcd = SteinGcd(a, b);
            clock.Stop();
            return Tuple.Create<int, double>(gcd, clock.Elapsed.TotalMilliseconds);
        }

        /// <summary>
        /// Overloaded  binary gcd function with time measure multiple arguments
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>gcd(param int[])</returns>
        public static Tuple<int, double> SteinGcdWithTimeMeasure(params int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Not enough parameters");
            }

            Stopwatch clock = new Stopwatch();
            clock.Start();
            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = SteinGcd(result, numbers[i]);
            }
            clock.Stop();
            return Tuple.Create<int, double>(result, clock.Elapsed.TotalMilliseconds);
        }
        #endregion
       
        #region PrivateMethods
        /// <summary>
        /// Recursive gcd Euklid
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd(a,b)</returns>
        private static int EuklidGcd(int a, int b)
        {
            return b == 0 ? a : EuklidGcd(b, a % b);
        }

        /// <summary>
        /// Binary gcd Stein algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd(a,b)</returns>
        private static int SteinGcd(int a, int b)
        {
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if ((~a & 1) == 1)
            {
                if ((b & 1) == 1)
                    return SteinGcd(a >> 1, b);
                else
                    return SteinGcd(a >> 1, b >> 1) << 1;
            }

            if ((~b & 1) == 1)
                return SteinGcd(a, b >> 1);

            if (a > b)
                return SteinGcd((a - b) >> 1, b);

            return SteinGcd((b - a) >> 1, a);
        }
        #endregion
    }
}
