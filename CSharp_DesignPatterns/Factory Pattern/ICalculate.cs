using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DesignPatterns.Factory_Pattern
{
    public interface ICalculate // must make this public aswell
    {
        void Calculate(double num1, double num2);
    }
}
