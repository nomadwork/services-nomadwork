using NomadWork.Domain.Account.Enum;
using NomadWork.Domain.Account.Location;

namespace NomadWork.Domain.Account
{
    
    public class Nomad : User
    {
        private Nomad(string userName, string numberPhone, string password, string email)
            : base(userName, numberPhone, password, email)
        {
            this.Type = UserType.Nomad;
        }

       
        public string Name { get; private set; }
        public Address GeoLocation { get; private set; }

        public static Nomad Create(string password, string email)
        {
            return (Nomad)User.Create(email,"8888888888",password,email);
        }
    }

}
