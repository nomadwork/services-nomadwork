namespace Nomadwork.Model_View
{
    public class Geolocation
    {
        private Geolocation()
        {
        }

        internal static Geolocation Create(decimal latitude, decimal longitude)
        {
            return new Geolocation
            {
                Latitude = latitude,
                Longitude = longitude
            };
        }

        public decimal Latitude { get; set; } = -10.01M;

        public decimal Longitude { get; set; } = 10.01M;
    }

}