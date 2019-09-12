using NomadWork.Domain.Account;
using NomadWork.Domain.Account.Location;
using NomadWork.Domain.Characteristics;
using NomadWork.Domain.Characteristics.Enums;
using NomadWork.Domain.Shared;
using System.Collections.Generic;

namespace NomadWork.Domain.Business
{
    public class Establishmment : AEntite
    {
        protected Establishmment(string name)
        {
            if (CheckEntryOk(new string[] { name }))
            {
                Name = name;
            }

            Chekout();
        }

        public static Establishmment Create(string name)
        {
            return new Establishmment(name);
        }

        public string Name { get; set; }
        public User Owner { get; private set; }
        public Address Address { get; private set; }

        public List<Characteristic> Characteristics { get; private set; }

        public void AddService(HasCharacteristc hasNotHas, ServiceOffered serviceOffered, ServiceOfferedQuality serviceOfferedQuality)
        {
            this.Characteristics.Add( Characteristic.Create( hasNotHas,  serviceOffered,  serviceOfferedQuality));
        }

        public void AddOwner(User owner)
        {
            this.Owner = owner;
        }

        public void AddOwner(string userName, string numberPhone, string password, string email)
        { 
            this.Owner = User.Create(userName,  numberPhone,  password,  email);
        }

        public void AddAddress(string street, string number, string zipCode, string coutry, string state, decimal latitude, decimal longitude)
        {
            this.Address =  Address.Create(street, number, zipCode, coutry, state, latitude, longitude);
        }

        public void AddAddress(Address address)
        {
            this.Address = address;
        }

        private void Chekout()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.AddErro("invalid establishmment data");
            }
        }

        protected override bool CheckEntryOk(string[] args)
        {
            var name = args[0];
            if (string.IsNullOrEmpty(name))
            {
                this.AddErro("invalid establishmment data");
                return false;
            }
            return true;
        }
    }
}
