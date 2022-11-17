namespace TendersApp.Users
{
    public class Customer : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Division { get; set; }

        public Customer(string login, string password, string email, string phoneNumber,
            string firstName, string lastName, string division, Enums.Roles role)
            : base(login, password, email, phoneNumber, role)
        {
            FirstName = firstName;
            LastName = lastName;
            Division = division;
        }

        public Customer(string login, string password,
            string email, string phoneNumber, Enums.Roles role) : base(login, password, email, phoneNumber, role)
        {

        }
    }
}
