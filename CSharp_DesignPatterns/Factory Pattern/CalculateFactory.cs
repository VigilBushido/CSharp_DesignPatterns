using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DesignPatterns.Factory_Pattern
{
    public class CalculateFactory // make sure it's public
    {
        public ICalculate GetCalculation(string type) // returns some type of ICalculate interface
        {
            ICalculate obj = null; // because it's inside a method you have to assign it a default value 
            // the superclass can be an interface , class, or abstract class 
            // superclass = new subsetclass in herits it's methods 
            if( type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                obj = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }
            return obj;
        }
    }
}
