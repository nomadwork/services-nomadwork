

namespace Nomadwork.ViewObject
{

    public class EstablishmmentNameLocationId
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public Geolocation Geolocation { get; private set; }


        internal static EstablishmmentNameLocationId Create(string id, string name, decimal latitude, decimal longitude)
           => new EstablishmmentNameLocationId
           {
               Id = id,
               Name = name,
               Geolocation = Geolocation.Create(latitude, longitude),
           };

    }
}