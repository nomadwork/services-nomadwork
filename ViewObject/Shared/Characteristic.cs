
namespace Nomadwork.ViewObject
{
    public class Characteristic
    {
        private Characteristic(short rate, string description)
        {
            Rate = rate;
            Description = description;
        }

        public Characteristic()
        {
        }

        public Characteristic(short rate)
        {
            Rate = rate;
        }

        public short Rate { get;  set; }
        public string Description { get;  set; }


        public static Characteristic Create(short rate, string description)
            => new Characteristic(rate, description);
    }

}
