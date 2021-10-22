using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DesignPatterns.Factory_Pattern
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1); // will try tp parse the input into a number and if so
            if (!result) // if successful result will be true
            {
                Console.WriteLine("Please enter a number");
                return;
            }
            Console.WriteLine("Enter second number");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter Add, Subtract or Divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            //Divide obj = new Divide();
            obj.Calculate(num1, num2);
        }
    }
}
