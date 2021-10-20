using System;

namespace CSharp_DesignPatterns
{
    class TestLog
    {
        static void Main(string[] args)
        {
            //Logger obj1 = new Logger();
            //Logger obj2 = new Logger();
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
