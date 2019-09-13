
namespace Nomadwork.Model_View.Establishmment_List
{
    public class EstablishmmentNameLocationId
    {
        private string _id;
        private string _name;
        private Geolocation _geolocation;

        public string Id { get => _id; }
        public string Name { get => _name; }

        public Geolocation Geolocation { get => _geolocation; }

        private EstablishmmentNameLocationId()
        {
        }

        internal static EstablishmmentNameLocationId Create(string id, string name, decimal latitude, decimal longitude)
        {
            var geolocation = Geolocation.Create(latitude, longitude);
            return new EstablishmmentNameLocationId
            {
                _id = id,
                _name = name,
                _geolocation = geolocation
            };

        }

    }

}