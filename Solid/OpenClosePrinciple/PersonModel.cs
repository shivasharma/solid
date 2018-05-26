namespace Solid.OpenClosePrinciple
{
    public class PersonModel : IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new Accounts();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}