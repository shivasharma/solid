﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosePrinciple
{
    public class EmployeeModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool IsExecutive { get; set; } = false;
        public bool IsManager { get; set; } = false;
        public string LastName { get; set; }
    }
}