using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosePrinciple
{
    public class ManagerModel : IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}