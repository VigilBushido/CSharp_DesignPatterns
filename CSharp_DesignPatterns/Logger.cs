using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns
{
    public class Logger
    {
        private static Logger logger;
        private Logger()
        {

        }
        // static method is 1 per class and not 1 per object
        // static methods can only call other static methods 
        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
    }
}
