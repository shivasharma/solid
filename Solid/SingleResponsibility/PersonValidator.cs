using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility
{
    public class PersonValidator
    {
        public static bool ValidatePerson(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidatorError("first name");
                Console.WriteLine("Invalid firstname");
                StandardMessages.EndApplication();
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidatorError("last name");
                StandardMessages.EndApplication();
                return false;
            }
            return true;
        }
    }
}