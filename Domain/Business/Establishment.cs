using Nomadwork.Domain.Shared;
using Nomadwork.Domain.Location;

namespace Nomadwork.Domain.Business
{
    public class Establishments : ADommain
    {
        private Establishments(string name, string email, string phone, string timeOpen, string timeClose)
        {
            if (CheckEntryOk(new string[] { name, timeOpen, timeClose, email, phone }))
            {
                Name = name;
                Timeopen = timeOpen;
                Timeclose = timeClose;
                Phone = phone;
            }
        }

        public string Name { get; private set; }
        public string Timeopen { get; private set; }
        public string Timeclose { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
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
        public static Establishments Create(string name, string email, string phone, string timeOpen, string timeClose)
            => new Establishments(name, email, phone, timeOpen, timeClose);

        public void SetAddress(Address address)
            => this.Address = address;



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