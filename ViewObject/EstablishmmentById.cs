using System.Collections.Generic;

namespace Nomadwork.ViewObject
{
    public class EstablishmmentById
    {

        public EstablishmmentById(string id, string name, string email, string phone, Schedule schedule, string completeAddress, Characteristic wifi, Characteristic noise, Characteristic plug)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Schedule = schedule;
            this.CompleteAddress = completeAddress;
            this.Wifi = wifi;
            this.Noise = noise;
            this.Plug = plug;

        }
        public string Id { get; private set; }

        public string Name { get; private set; }


        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Schedule Schedule { get; private set; }


        public string CompleteAddress { get; private set; }
        public List<string> UrlPhoto { get; private set; }

        public Characteristic Wifi { get; private set; }
        public Characteristic Noise { get; private set; }
        public Characteristic Plug { get; private set; }


        private EstablishmmentById()
        {
            this.UrlPhoto = new List<string>();
        }


        internal static EstablishmmentById Create(string id, string name, string adress, string email, string phone, string hourToOpen, string hourToClose)
            => new EstablishmmentById
            {
                Id = id,
                Name = name,
                CompleteAddress = adress,
                Schedule = Schedule.Create(hourToOpen, hourToClose),
                Email = email,
                Phone = phone
            };


        internal void AddPhoto(string urlPhoto)
             => UrlPhoto.Add(urlPhoto);

        internal void SetCharacteristics(Characteristic wifi, Characteristic noise, Characteristic plug)
        {
            this.Wifi = wifi;
            this.Noise = noise;
            this.Plug = plug;
        }

    }
}