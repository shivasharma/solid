using System;
using System.Collections.Generic;

namespace Solid.OpenClosePrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var applicants = new List<IApplicantModel>
            {
                new PersonModel{FirstName="Tim", LastName="John" },
                new ManagerModel{FirstName="Shiva", LastName="Sharma" }
            };

            var employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
                Console.WriteLine($"{emp.FirstName}{emp.LastName}{emp.Email} IsManager: {emp.IsManager} IsExecutive:{emp.IsExecutive}");

            Console.ReadLine();
        }
    }
}