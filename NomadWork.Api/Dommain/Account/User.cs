using NomadWork.Domain.Account.Enum;
using NomadWork.Domain.Account.Location;
using NomadWork.Domain.Shared;

namespace NomadWork.Domain.Account
{
    public class User : AEntite
    {
        protected User(string userName, string numberPhone, string password, string email)
        {
            if (CheckEntryOk(new string[] { userName, numberPhone, password, email }))
            {
                UserName = userName;
                NumberPhone = numberPhone;
                Password = password;
                Email = email;
                Active = true;
            }
            
            Checkout();
        }

        public string UserName { get; private set; }
        public string NumberPhone { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        public UserType Type { get; protected set; }
        public Address Address { get; private set; }


        internal static User Create(string userName, string numberPhone, string password, string email)
        {
            return new User(userName, numberPhone, password, email);
        }

        protected override bool CheckEntryOk(string[] args)
        {
            var userName = args[0];
            var numberPhone = args[1];
            var password = args[2];
            var email = args[3];

            if (string.IsNullOrEmpty(userName)
                || string.IsNullOrEmpty(numberPhone)
                || string.IsNullOrEmpty(password)
                || string.IsNullOrEmpty(email))
            {
                AddErro("invalid user nomad data");
                return false;
            }

            return true;
        }

        private void Checkout()
        {
            if (string.IsNullOrEmpty(this.UserName)
               || string.IsNullOrEmpty(this.NumberPhone)
               || string.IsNullOrEmpty(this.Email)
               || string.IsNullOrEmpty(this.Password)
               || !Active)
            {
                AddErro("invalid user nomad data");
            }
        }

        public void Inactive()
        {
            this.Active = false;
        }

        public void AddAddres(string street, string number, string zipCode, string coutry, string state, decimal latitude, decimal logitude)
        {
            Address =  Address.Create(street, number, zipCode, coutry, state, latitude, logitude);
        }
    }
}
