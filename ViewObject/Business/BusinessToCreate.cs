using System.Collections.Generic;

namespace Nomadwork.ViewObject.Business
{
    public class BusinessToCreate
    {
       

        public UserToCreate User { get; set; }

        public List<EstablishmmentToCreate> Establishmments { get; set; }
    }
}
