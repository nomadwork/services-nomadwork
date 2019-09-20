namespace services_nomadwork.Infra.Model
{
    public class Address
    {
        
        // public string Id { get; set; }

        
        public string Zipcode { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Coutry { get; private set; }
        public string State { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }
    }
}