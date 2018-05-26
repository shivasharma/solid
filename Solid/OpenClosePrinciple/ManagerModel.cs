namespace Solid.OpenClosePrinciple
{
    public class ManagerModel : IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}