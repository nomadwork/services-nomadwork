using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;

namespace Nomadwork.Infra
{
    public static class Convert
    {

        public static EstablishmentModelData To(EstablishmmentCreate establishmment)
        {
           

            return new EstablishmentModelData
            {
                Name = establishmment.Name,
                Phone = establishmment.Phone,
                Email = establishmment.Email,
                Address = new AddressModelData { Latitude = establishmment.Latitude, Longitude = establishmment.Longitude },
                TimeOpen = establishmment.Schedule.Open,
                TimeClose = establishmment.Schedule.Close,
                Wifi = establishmment.Wifi.Rate,
                Plug = establishmment.Plug.Rate,
                Noise = establishmment.Plug.Rate
            };
               
            }

        public static EstablishmmentById To(EstablishmentModelData data)
        {
            var establishmment = EstablishmmentById.Create(
                                data.Id.ToString(),
                                data.Name,
                                string.Join(", ", data.Address.Street, data.Address.Number, data.Address.State, data.Address.Coutry, data.Address.Zipcode),
                                data.TimeOpen,
                                data.TimeClose);
           
            var desWifi = "";
           
            switch (data.Wifi)
            {
                case 0:
                    desWifi = "não tem";
                    break;
                case 1:
                    desWifi = "fraco";
                    break;
                case 2:
                    desWifi = "médio";
                    break;
                case 3:
                    desWifi = "forte";
                    break;
                default: desWifi = "";
                    break;

            }

            var desNoise = "";

            switch (data.Noise)
            {
                case 0:
                    desNoise = "não tem";
                    break;
                case 1:
                    desNoise = "pouco";
                    break;
                case 2:
                    desNoise = "médio";
                    break;
                case 3:
                    desNoise = "muito";
                    break;
                default:
                    desWifi = "";
                    break;

            }

            var desPlug = "";

            switch (data.Plug)
            {
                case 0:
                    desPlug = "não tem";
                    break;
                case 1:
                    desPlug = "pouco";
                    break;
                case 2:
                    desPlug = "alguns";
                    break;
                case 3:
                    desPlug = "vários";
                    break;
                default:
                    desWifi = "";
                    break;

            }


            establishmment.SetCharacteristics(Characteristic.Create(data.Wifi,desWifi),
                                              Characteristic.Create(data.Noise, desNoise),
                                              Characteristic.Create(data.Plug, desPlug));
            data.Photos.ForEach(x => establishmment.AddPhoto(x.UrlPhoto));

            return establishmment;
        }
        
    }
}
