using System.Collections.Generic;

namespace Nomadwork.Model_View.Establishmment_List
{
    public class EstablishmmentNameLocationId
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string CompleteAddress { get;private set; }
        public Geolocation Geolocation { get; private set; }
        public List<string> UrlPhoto { get; private set; }

        private EstablishmmentNameLocationId() 
            => UrlPhoto = new List<string>();

        internal static EstablishmmentNameLocationId Create(string id, string name, decimal latitude, decimal longitude, string completeAddress, List<string> urlsPhoto)
           => new EstablishmmentNameLocationId
           {
               Id = id,
               Name = name,
               CompleteAddress = completeAddress,
               Geolocation = Geolocation.Create(latitude, longitude),
               UrlPhoto = urlsPhoto
           };

        internal void AddPhoto(string urlPhoto)
             => UrlPhoto.Add(urlPhoto);


        internal void AddPhoto(List<string> urlsPhoto)
            => UrlPhoto.AddRange(urlsPhoto);

    }

}