namespace Nomadwork.Model_View
{
    public class ServiceOffered
    {
        private Quantity _quantity;

        private Quality _quality;

        private Service _service;


        private ServiceOffered() { }

        public static ServiceOffered Internet(Quality quality)
                => new ServiceOffered
                {
                    _service = Service.Internet,
                    _quantity = Quantity.Has,
                    _quality = quality
                };

        public static ServiceOffered Noise(Quantity quantity)
                => new ServiceOffered
                {
                    _service = Service.Noise,
                    _quantity = quantity
                };

        public static ServiceOffered Energy(Quantity quantity)
                => new ServiceOffered
                {
                    _service = Service.Energy,
                    _quantity = quantity
                };

        public Quantity Quantity { get => _quantity; }

        public Quality Quality { get => _quality; }

        public Service Service { get => _service; }
    }
}