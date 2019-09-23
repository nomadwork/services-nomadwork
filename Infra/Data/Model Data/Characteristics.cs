using Nomadwork.Shared;

namespace Nomadwork.Infra.Data.Model_Data
{
    public class Characteristic:AEntity
    {
        public Quantity Quantity { get; set; }

        public Quality Quality { get; set; }

        public Service Service { get; set; }
    }
}
