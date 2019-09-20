
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

        private EstablishmmentById()
            => _services = new List<ServiceOffered>();


        public static EstablishmmentById Create(string id, string name, string hourToOpen, string hourToClose)
            => new EstablishmmentById
            {
                Id = id,
                Name = name,
                Schedule = Schedule.Create(hourToOpen, hourToClose)
            };


        public void AddServices(ServiceOffered service)
            => this._services.Add(service);

    }
}