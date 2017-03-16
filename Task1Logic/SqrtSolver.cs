using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    public static class SqrtSolver
    {
        #region Methods

        /// <summary>
        /// Newton sqrt function 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="eps"></param>
        /// <returns>sqrt(number)</returns>
        public static double NewtonMethod(int number, double eps = 0.00000000001)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number is below zero");
            }

            double x = 1;

            while (true)
            {
                double nextX = (x + number / x) / 2;
                if (Math.Abs(x - nextX) < eps) break;
                x = nextX;
            }

            return x;
        }
        #endregion
    }
}
