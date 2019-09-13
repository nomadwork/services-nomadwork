using System.Collections.Generic;

namespace Nomadwork.Model_View.Establishmment_List
{
    public class ResultListEstablishmmentNameLocationId
    {
        public IEnumerable<EstablishmmentNameLocationId> Establishmments { get => _establishmments; }
        private List<EstablishmmentNameLocationId> _establishmments;

        private ResultListEstablishmmentNameLocationId()
        {
            _establishmments = new List<EstablishmmentNameLocationId>();
        }
        public static ResultListEstablishmmentNameLocationId GetInstance()
            => new ResultListEstablishmmentNameLocationId();

        private void AddEstaBlishment(EstablishmmentNameLocationId establishmment)
           => this._establishmments.Add(establishmment);

        public void AddEstaBlishment(string id, string name, decimal latitude, decimal longitude)
        {
            var establishmment = EstablishmmentNameLocationId.Create(id, name, latitude, longitude);

            AddEstaBlishment(establishmment);
        }
    }
}