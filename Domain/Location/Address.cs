using services_nomadwork.Domain.Shared;

namespace services_nomadwork.Domain.Location
{
    public class Address : AEntite
    {
        protected Address(string street, string number, string zipCode, string coutry, string state, decimal latitude, decimal longitude)
        {
            if (CheckEntryOk(new string[] { street, number, zipCode, coutry, state }))
            {
                Street = street;
                Number = number;
                ZipCode = zipCode;
                Coutry = coutry;
                State = state;
                Latitude = latitude;
                Longitude = longitude;
            }
        }

        public static Address Create(string street, string number, string zipCode, string coutry, string state, decimal latitude, decimal longitude)
        {
            return new Address(street, number, zipCode, coutry, state, latitude, longitude);
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public string Coutry { get;private set; }
        public string State { get;private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }

       
        protected override bool CheckEntryOk(string[] args)
        {
            var street = args[0];
            var number = args[1];
            var zipCode = args[2];
            var coutry = args[3];
            var state = args[4];

            if (string.IsNullOrEmpty(street)
                || string.IsNullOrEmpty(number)
                || string.IsNullOrEmpty(zipCode)
                || string.IsNullOrEmpty(coutry)
                || string.IsNullOrEmpty(state))
            {
                AddErro("invalid adress data");
                return false;
            }

            return true;
        }
    }
}