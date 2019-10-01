namespace Nomadwork.ViewObject
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

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }

}