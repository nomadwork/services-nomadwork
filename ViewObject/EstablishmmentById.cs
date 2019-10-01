using System.Collections.Generic;

namespace Nomadwork.ViewObject
{
    public class EstablishmmentById
    {

        public string Id { get; private set; }

        public string Name { get; private set; }

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


        internal static EstablishmmentById Create(string id, string name, string adress, string hourToOpen, string hourToClose)
            => new EstablishmmentById
            {
                Id = id,
                Name = name,
                CompleteAddress = adress,
                Schedule = Schedule.Create(hourToOpen, hourToClose)
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