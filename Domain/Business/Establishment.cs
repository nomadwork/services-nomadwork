using Nomadwork.Model_View;
using services_nomadwork.Domain.Shared;
using services_nomadwork.Infra.Model;

namespace services_nomadwork.Domain.Business
{
    public class Establishments : AEntite
    {
        protected Establishments(string name,Address address, Wifi wifi,bool power, Noise noise, string timeopen, string timeclose, string email, float phone)
        {
            
            Name = name;
            Address = address;
            Wifi = wifi;
            Power = power;
            Noise = noise;
            Timeopen = timeopen;
            Timeclose = timeclose;
            
        }
        public string Name  { get; private set; }
        public Address Address { get; private set; }
        public Wifi Wifi { get; private set; }
        public bool Power { get; private set; }
        public Noise Noise { get; private set; }
        public string Timeopen { get; private set; }
        public string Timeclose { get; private set; }
        public string Email { get; private set; }
        public float Phone { get; private set; }

        protected override bool CheckEntryOk(string[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}