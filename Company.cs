using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {



        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; set; }

        public void AddEmployee(Employee worker)
        {
            Employees.Add(worker);
        }
        public Company(string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
            Employees = new List<Employee>();
        }
        public void printList()
        {
            foreach (Employee info in Employees)
            {
                Console.WriteLine($"{info.FirstName} {info.LastName} works for GusInc as {info.Title} since {info.StartDate}");
            }
        }

    }
}

// Create a public property for holding a list of current employees


/*
    Create a constructor method that accepts two arguments:
        1. The name of the company
        2. The date it was created

    The constructor will set the value of the public properties

*/