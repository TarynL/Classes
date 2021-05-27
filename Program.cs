using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company GusInc = new Company("GusInc", DateTime.Now);
            // Create three employees
            Employee oneEmployee = new Employee("Barbara", "Honey", "Manager", DateTime.Now);
            Employee twoEmployee = new Employee("Frank", "Apple", "Assistant", DateTime.Now);
            Employee threeEmployee = new Employee("Earl", "Coffee", "Shift Lead", DateTime.Now);
            // Assign the employees to the company

            GusInc.AddEmployee(oneEmployee);
            GusInc.AddEmployee(twoEmployee);
            GusInc.AddEmployee(threeEmployee);
            GusInc.printList();
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}

