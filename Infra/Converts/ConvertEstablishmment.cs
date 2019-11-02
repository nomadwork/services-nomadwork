using Nomadwork.Domain.Business;
using Nomadwork.Domain.Location;
using Nomadwork.Infra.Converts;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;
using System.Collections.Generic;
using System.Linq;

namespace Nomadwork.Infra
{
    public static class ConvertEstablishmment
    {
        public static EstablishmmentSugestionModelData ToEstablishmmentSugestion(this Establishmment establishmment)
        {
            return new EstablishmmentSugestionModelData
            {
                Name = establishmment.Name,
                Phone = establishmment.Phone,
                Email = establishmment.Email,
                Latitude = establishmment.Address.Latitude,
                Longitude = establishmment.Address.Longitude,
                TimeOpen = establishmment.Timeopen,
                TimeClose = establishmment.Timeclose,
                Wifi = establishmment.Wifi,
                Plug = establishmment.Plug,
                Noise = establishmment.Plug
            };
        }


        public static IEnumerable<EstablishmmentNameLocationId> ToEstablishmmentNameLocationIdList(this IEnumerable<EstablishmmentModelData> list)
        {
            var listEstablishment = new List<EstablishmmentNameLocationId>();
            list.ToList().ForEach(x =>
            {
                listEstablishment.Add(EstablishmmentNameLocationId.Create(x.Id.ToString(), x.Name, x.Address.Latitude, x.Address.Longitude));

            });

            return listEstablishment;
        }

        public static Establishmment ToEstablishmment(this EstablishmmentCreate establishmment)
        {
            var validate = Establishmment.Create(establishmment.Name.Trim(), establishmment.Email.Trim(), establishmment.Phone.Trim(), establishmment.Schedule.Open.ToSchedule(), establishmment.Schedule.Close.ToSchedule(), establishmment.Wifi.Rate, establishmment.Noise.Rate, establishmment.Plug.Rate);

            var addres = Address.Create("Sem endereço", "Sem número", "SemCEP", "Sem Local", "SU", establishmment.Latitude, establishmment.Longitude);

            validate.SetAddress(addres);

            return validate;
        }



        public static EstablishmmentById ToEstablishmmentById(this EstablishmmentModelData data)
        {
            var establishmment = EstablishmmentById.Create(
                                data.Id.ToString(),
                                data.Name,
                                string.Join(", ", data.Address.Street, data.Address.Number, data.Address.State, data.Address.Coutry, data.Address.Zipcode),
                                data.Email,
                                data.Phone,
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
                default:
                    desWifi = "";
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


            establishmment.SetCharacteristics(Characteristic.Create(data.Wifi, desWifi),
                                              Characteristic.Create(data.Noise, desNoise),
                                              Characteristic.Create(data.Plug, desPlug));
            data.Photos.ForEach(x => establishmment.AddPhoto(x.UrlPhoto));

            return establishmment;
        }


    }
}
