using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DesignPatterns.Basic_Concepts
{
    //A doesn't have to be a class it can also be an interface
    //interface IA
    class A
    {
        public virtual void MethodA() // make this virtual to override
        {
            Console.WriteLine("A - MA");
        }
    }

    
    //class B : IA // B implements IA 
    class B : A
    {
        public override void MethodA() // override to test if it's a B object in "A obj1 = new B()";
        {
            Console.WriteLine("B - MA");
        }
        public void MethodB()
        {
            Console.WriteLine("B - MB");
        }
    }

    class Test
    {
        static void Main()
        {
            //Console.WriteLine("A obj");
            //A aobj = new A();
            //aobj.MethodA();

            Console.WriteLine("B obj");
            B bobj = new B();
            bobj.MethodA();
            bobj.MethodB();

            Console.WriteLine("A or B?");
            //Superclass obj = new Subclass();
            int x = 10;
            A obj1 = new B(); // cannot create objects of an interface but can specify this is a B object
            // the left hand side provides the behavior or property  & right hand side provides the value

            // one way to access methods in class B would be by casting
            ((B)obj1).MethodB();
            // or using the " as " keyword
            (obj1 as B).MethodB();

            obj1.MethodA(); // by default
            // even tho it shows us only A object methods it will take B method A method to use
            // the property of obj1 is A. and act like the B method
            //cannot do V
            //B obj2 = new A(); X cannot say subclass obj = new superclass
        }
    }
}
