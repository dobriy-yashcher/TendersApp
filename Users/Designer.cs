namespace TendersApp.Users
{
    public class Designer : User
    {
        public string Organisation { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Adress { get; set; }
        public string Director { get; set; }
        public string MainEngineer { get; set; }

        public Designer(string email, string phoneNumber, string login,
            string password, Enums.Roles role, string organisation, string ogrn, string inn, string kpp, string adress, string director, string mainEngineer)
            : base(email, phoneNumber, login, password, role)
        {
            Organisation = organisation;
            Ogrn = ogrn;
            Inn = inn;
            Kpp = kpp;
            Adress = adress;
            Director = director;
            MainEngineer = mainEngineer;

        }

        public Designer(string email, string phoneNumber,
            string login, string password, Enums.Roles role) : base(email, phoneNumber, login, password, role)
        {

        }

    }
}
