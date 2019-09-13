
using System.Collections.Generic;

namespace Nomadwork.Model_View
{
    public class EstablishmmentById
    {
        private string _id;
        private string _name;
        private Schedule _schedule;
        private List<ServiceOffered> _services;

        public string Id { get => _id; }

        public string Name { get => _name; }

        public Schedule Schedule { get => _schedule; }

        public IEnumerable<ServiceOffered> Services { get => _services; }

        private EstablishmmentById()
        {
            _services = new List<ServiceOffered>();
        }

        public static EstablishmmentById Create(string id, string name, string hourToOpen, string hourToClose)
        {
            var schedule = Schedule.Create(hourToOpen, hourToClose);
            return new EstablishmmentById
            {
                _id = id,
                _name = name,
                _schedule = schedule
            };
        }

        public void AddServices(ServiceOffered service) => this._services.Add(service);

    }
}