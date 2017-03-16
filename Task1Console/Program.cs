using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(5, 0.5));
            Console.WriteLine(SqrtSolver.NewtonMethod(5,0.0000001)-Math.Pow(5,0.5));
            
            Console.ReadKey();
        }
    }
}
