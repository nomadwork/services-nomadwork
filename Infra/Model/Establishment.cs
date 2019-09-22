using Nomadwork.Model_View;

namespace services_nomadwork.Infra.Model
{
    public class Establishment
    {
        public string Name  { get; private set; }
        public Address Address { get; private set; }
        public Wifi Wifi { get; private set; }
        public bool Power { get; private set; }
        public Noise Noise { get; private set; }
        public string Timeopen { get; private set; }
        public string Timeclose { get; private set; }
        public string Email { get; private set; }
        public float Phone { get; private set; }
    }
}