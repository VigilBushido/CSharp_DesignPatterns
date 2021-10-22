using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DesignPatterns.Factory_Pattern
{
    public class Divide : ICalculate // must make this public aswell
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a / b is {0}", a / b);
        }
    }
}
