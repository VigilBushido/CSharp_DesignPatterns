using System;

namespace CSharp_DesignPatterns
{
    class TestLog
    {
        static void Main(string[] args)
        {   
            //If we want a class to have only one object , then we use the singleton pattern 
            // used for logging , device drivers for printers, if there are multiple objects
            // we may encounter inconsistent results etc. 
            Console.WriteLine("*---Singleton---*");
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine("*---Non Singleton---*");
            TestLog obj3 = new TestLog();
            TestLog obj4 = new TestLog();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
    }
}
