using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GcdSolver.EuklidGcdWithTimeMeasure(8,2));
            Console.WriteLine(GcdSolver.SteinGcdWithTimeMeasure(400,1600,20));
            
            Console.ReadKey();
        }
    }
}
