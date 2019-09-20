using System.Collections.Generic;

namespace Nomadwork.Model_View.Establishmment_List
{
    public class ResultListEstablishmmentNameLocationId
    {
        public List<EstablishmmentNameLocationId> Establishmments { get; }


        private ResultListEstablishmmentNameLocationId()
            => Establishmments = new List<EstablishmmentNameLocationId>();


        public static ResultListEstablishmmentNameLocationId GetInstance()
            => new ResultListEstablishmmentNameLocationId();


        public void AddEstaBlishment(EstablishmmentNameLocationId establishmment)
           => this.Establishmments.Add(establishmment);


        public void AddEstaBlishment(List<EstablishmmentNameLocationId> establishmments)
           => this.Establishmments.AddRange(establishmments);


        public void AddEstaBlishment(string id, string name, decimal latitude, decimal longitude)
            => AddEstaBlishment(EstablishmmentNameLocationId.Create(id, name, latitude, longitude));

    }
}