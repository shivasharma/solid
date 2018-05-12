using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility
{
    public static class StandardMessages
    {
        public static void DisplayValidatorError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("welcome to the application");
        }
    }
}