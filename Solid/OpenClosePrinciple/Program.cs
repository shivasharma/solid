using System;
using System.Collections.Generic;

namespace Solid.OpenClosePrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var applicants = new List<PersonModel>
            {
                new PersonModel{FirstName="Tim", LastName="John" },
                new PersonModel{FirstName="Shiva", LastName="Sharma" }
            };

            var employees = new List<EmployeeModel>();
            var accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
                Console.WriteLine($"{emp.FirstName}{emp.LastName}{emp.Email}");

            Console.ReadLine();
        }
    }
}