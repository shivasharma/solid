namespace Solid.OpenClosePrinciple
{
    public interface IApplicantModel
    {
        IAccounts AccountProcessor { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}