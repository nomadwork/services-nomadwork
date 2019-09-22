
using System.Collections.Generic;

namespace Nomadwork.Model_View
{
    public class EstablishmmentById
    {
        private readonly List<ServiceOffered> _services;

        public string Id { get; private set; }

        public string Name { get; private set; }

        public Schedule Schedule { get; private set; }

        public IEnumerable<ServiceOffered> Services { get => _services; }
        public string CompleteAddress { get; private set; }
        public List<string> UrlPhoto { get; private set; }


        private EstablishmmentById()
        {
            this._services = new List<ServiceOffered>();
            this.UrlPhoto = new List<string>();
        }


        public static EstablishmmentById Create(string id, string name, string hourToOpen, string hourToClose)
            => new EstablishmmentById
            {
                Id = id,
                Name = name,
                Schedule = Schedule.Create(hourToOpen, hourToClose)
            };


        public void AddServices(ServiceOffered service)
            => this._services.Add(service);


        internal void AddPhoto(string urlPhoto)
             => UrlPhoto.Add(urlPhoto);


        internal void AddPhoto(List<string> urlsPhoto)
            => UrlPhoto.AddRange(urlsPhoto);
    }
}