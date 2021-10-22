using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DesignPatterns.Basic_Concepts
{
    class Employee
    {
        private int empId;
        private string empName; // if change may occur you can keep it public 
        public double salary { get; set; } //not absolutely required and can change at any time- frequently changing values
        public int grade { get; set; }
        public string company = "IBM"; // hardcoded value for every object created
        // table columns become Class properties

        IEmail email; // email is a variable of type IEmail
        //remember we cannot create objects of an interface but we can create a subclass later on and insert it to IEmail

        //we insist on requiring the empId and empName in this situation
        public Employee(int empId, string empName, IEmail email) // using this constructor to set values
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee()
        {
            email.SendEmail();
        }
    }

    
    class TestEmployee
    {
        static void Main()
        {
            IEmail email = new OutlookEmail();
            //objects will become 1 record of the table
            Employee obj = new Employee(100, "Alex", email);
            obj.salary = 100000;
            obj.NotifyEmployee();

            //reuse the object
            email = new WebserviceEmail();
            Employee obj3 = new Employee(200, "Lynda", email);
            obj3.NotifyEmployee();

        }
    }
}
