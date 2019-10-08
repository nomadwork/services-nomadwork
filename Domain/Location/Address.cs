using Nomadwork.Domain.Shared;

namespace Nomadwork.Domain.Location
{
    public class Address : ADommain
    {
        protected Address(string street, string number, string zipCode, string coutry, string state)
        {
            if (CheckEntryOk(new string[] { street, number, zipCode, coutry, state }))
            {
                Street = street;
                Number = number;
                ZipCode = zipCode;
                Coutry = coutry;
                State = state;
            }
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string ZipCode { get; private set; }
        public string Coutry { get; private set; }
        public string State { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }


        /// <summary>
        /// Cria uma nova instância de Address **sem Geolocalização**
        /// <para>***Será necessário utilizar o método*** **SetGeolocation**</para> 
        /// </summary>
        /// <param name="street">Nome da rua referente ao endereço. Ex: Estarda da Batalha</param>
        /// <param name="number">Número referente ao endereço. Ex: 1001 A</param>
        /// <param name="zipCode">CEP Referente ao endereço. Ex: 53000-000</param>
        /// <param name="coutry">País referente ao endereço. Ex: Brasil</param>
        /// <param name="state">Estado referente ao endereço. Ex: PE</param>
        /// <returns>Retorna um novo Address Sem Geolocalização</returns>
        private static Address Create(string street, string number, string zipCode, string coutry, string state)
            => new Address(street, number, zipCode, coutry, state);


        /// <summary>
        /// Cria uma nova instância de Address **com Geolocalização**
        /// </summary>
        /// <param name="street">Nome da rua referente ao endereço. Ex: Estarda da Batalha</param>
        /// <param name="number">Número referente ao endereço. Ex: 1001 A</param>
        /// <param name="zipCode">CEP Referente ao endereço. Ex: 53000-000</param>
        /// <param name="coutry">País referente ao endereço. Ex: Brasil</param>
        /// <param name="state">Estado referente ao endereço. Ex: PE</param>
        /// <param name="latitude">Latitude da Geolocalização</param>
        /// <param name="longitude">Longitude da Geolocalizaçao</param>
        /// <returns>Retorna um novo Address Com Geolocalização</returns>
        public static Address Create(string street, string number, string zipCode, string coutry, string state, decimal latitude, decimal longitude)
        {
            var address = Create(street, number, zipCode, coutry, state);
            address.SetGeolocation(latitude, longitude);
            return address;
        }

        /// <summary>
        /// **Atribui a Geolocalização a um Adress já existente**
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public void SetGeolocation(decimal latitude, decimal longitude)
        {
            if (CheckEntryOk(latitude, longitude))
            {
                this.Latitude = latitude;
                this.Longitude = longitude;
            }
        }


        /// <summary>
        /// **Verifica se o conjunto de parâmentros informados atendem a regra de negócio.**
        /// <code>new string[]{param1,param2,param3,...}</code>
        /// </summary>
        /// <param name="args">*new string[]{param1,param2,param3,...}*</param>
        protected override bool CheckEntryOk(string[] args)
        {
            // TODO: descrever toda a regra de negócio de Address
            var ok = true;
            var street = args[0];
            var number = args[1];
            var zipCode = args[2];
            var coutry = args[3];
            var state = args[4];

            if (string.IsNullOrEmpty(street)
                || string.IsNullOrEmpty(number)
                || string.IsNullOrEmpty(zipCode)
                || string.IsNullOrEmpty(coutry)
                || string.IsNullOrEmpty(state))
            {
                AddErro("invalid adress data");
                ok = false;
            }

            return ok;
        }


        /// <summary>
        /// **Verifica se a Geolocalização informada atende a regra de negócio.**
        /// </summary>
        /// <param name="latitude">decimal referente a latitude</param>
        /// <param name="longitude">decimal referente a longitude</param>
        /// <returns>**Retorna ***true*** caso a Geolocalização atenda a regra de negócio</returns>
        private bool CheckEntryOk(decimal latitude, decimal longitude)
        {
            var ok = true;
            if (latitude == 0 || longitude == 0)
            {
                AddErro("Os valores de Latitude e Longitude devem ser maiores que zero!");
                ok = false;
            }

            return ok;
        }
    }
}