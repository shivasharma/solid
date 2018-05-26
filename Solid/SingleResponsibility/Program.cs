using Solid.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            Person user = PersonDataCapture.Capture();
            //check for null
            bool isUserValide = PersonValidator.ValidatePerson(user);
            if (!isUserValide)
            {
                StandardMessages.EndApplication();
                return;
            }
            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}