namespace Nomadwork.ViewObject
{
    public class EstablishmmentCreate
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public Schedule Schedule { get; set; }
        public Characteristic Wifi { get; set; }
        public Characteristic Noise { get; set; }
        public Characteristic Plug { get; set; }
    }

}
