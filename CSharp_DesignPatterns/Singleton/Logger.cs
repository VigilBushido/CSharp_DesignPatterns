using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns
{
    public class Logger
    {
        private static Logger instance;
        //private static Logger logger; // to call this we make it static as well
        private Logger() // instance made private 
        {

        }
        // static method is 1 per class and not 1 per object
        // static methods can only call other static methods 
/*        public static Logger GetInstance() // gain access by making it static 
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }*/
        public static Logger Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }
}
