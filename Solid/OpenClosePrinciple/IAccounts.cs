﻿namespace Solid.OpenClosePrinciple
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}