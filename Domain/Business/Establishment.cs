using Nomadwork.Domain.Shared;
using Nomadwork.Domain.Location;


namespace Nomadwork.Domain.Business
{
    public class Establishment : ADommain
    {
        private Establishment(string name, string email, string phone, string timeOpen, string timeClose, short wifi, short noise, short plug)
        {
            if (CheckEntryOk(new string[] { name, timeOpen, timeClose, email, phone  }) && CheckEntryOk(wifi, noise, plug))
            {
                Name = name;
                Timeopen = timeOpen;
                Timeclose = timeClose;
                Wifi = wifi;
                Noise = noise;
                Plug = plug;
                Phone = phone;
           
            }
        }

        public string Name { get; private set; }
        public string Timeopen { get; private set; }
        public string Timeclose { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public short Wifi { get; private set; }
        public short Noise { get; private set; }
        public short Plug { get; private set; }
        public Address Address { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="timeOpen"></param>
        /// <param name="timeClose"></param>
        /// <returns>**Retorna um novo objeto** ***Establishmment***</returns>
        public static Establishment Create(string name, string email, string phone, string timeOpen, string timeClose, short wifi, short noise, short plug)
            => new Establishment(name, email, phone, timeOpen, timeClose, wifi,  noise,  plug);

        public void SetAddress(Address address)
            => this.Address = address;

        private bool CheckEntryOk(short wifi, short noise, short plug)
        {
            var ok = true;
            if (wifi > 3 || wifi < 0)
            {
                AddErro("este valor não é válido para wifi, no máximo 3");
                ok = false;
            }
            if (noise > 3 || noise < 0)
            {
                AddErro("este valor não é válido para noise, no máximo 3");
                ok = false;
            }
            if(plug > 3 || plug < 0)
            {
                AddErro("este valor não é válido para plug, no máximo 3");
                ok = false;
            }
           
            return ok;
        }

        // TODO: descrever toda a regra de negócio de Establissment
        protected override bool CheckEntryOk(string[] args)
        {
            var ok = true;
            var name = args[0];
            var timeOpen = args[1];
            var timeClose = args[2];
            var email = args[3];
            var phone = args[4];
          

            if (string.IsNullOrEmpty(name))
            {
                AddErro("Nome pode ser vazio");
                ok = false;
            }

            if (string.IsNullOrEmpty(name))
            {
                AddErro("Nome pode ser vazio");
                ok = false;
            }
            return ok;

        }

    }
}