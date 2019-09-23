
namespace Nomadwork.Shared
{
    public class ServiceOffered
    {
        public Quantity Quantity { get; private set; }

        public Quality Quality { get; private set; }

        public Service Service { get; private set; }


        private ServiceOffered() { }

        public static ServiceOffered Internet(Quality quality)
            => new ServiceOffered
            {
                Service = Service.Internet,
                Quantity = Quantity.Has,
                Quality = quality
            };

        public static ServiceOffered Noise(Quantity quantity)
            => new ServiceOffered
            {
                Service = Service.Noise,
                Quantity = quantity
            };

        public static ServiceOffered Energy(Quantity quantity)
            => new ServiceOffered
            {
                Service = Service.Energy,
                Quantity = quantity
            };
    }
}