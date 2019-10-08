using Nomadwork.Domain.Business;
using Nomadwork.Domain.Location;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nomadwork.Infra
{
    public static class Convert
    {
        //public static EstablishmentModelData To(Establishment establishmment)
        //{
        //    return new EstablishmentModelData
        //    {
        //        Name = establishmment.Name,
        //        Phone = establishmment.Phone,
        //        Email = establishmment.Email,
        //        Address = new AddressModelData
        //        {
        //            Latitude = establishmment.Address.Latitude,
        //            Longitude = establishmment.Address.Longitude,
        //            LatitudePrecision = decimal.Round(establishmment.Address.Latitude, 2),
        //            LongitudePricision = decimal.Round(establishmment.Address.Longitude, 2)
        //        },
        //        TimeOpen = establishmment.Timeopen,
        //        TimeClose =establishmment.Timeclose,
        //        Wifi = establishmment.Wifi,
        //        Plug = establishmment.Plug,
        //        Noise = establishmment.Plug
        //    };
        //}

        public static EstablishmmentSugestionModelData To(Establishmment establishmment)
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


        public static IEnumerable<EstablishmmentNameLocationId> To(IEnumerable<EstablishmmentModelData> list)
        {
            var listEstablishment = new List<EstablishmmentNameLocationId>();
            list.ToList().ForEach(x =>
            {
                listEstablishment.Add(EstablishmmentNameLocationId.Create(x.Id.ToString(), x.Name, x.Address.Latitude, x.Address.Longitude));

            });

            return listEstablishment;
        }

        public static Establishmment To(EstablishmmentCreate establishmment)
        {
            var validate = Establishmment.Create(establishmment.Name.Trim(), establishmment.Email.Trim(), establishmment.Phone.Trim(), ConvertSchedule(establishmment.Schedule.Open), ConvertSchedule(establishmment.Schedule.Close), establishmment.Wifi.Rate, establishmment.Noise.Rate, establishmment.Plug.Rate);

            var addres = Address.Create("Sem endereço", "Sem número", "SemCEP", "Sem Local", "SU", establishmment.Latitude, establishmment.Longitude);

            validate.SetAddress(addres);

            return validate;
        }

        private static DateTime ConvertSchedule(string time)
        {
            var data = time.Split(':');
            var hour = int.Parse(data[0]);
            var minute = int.Parse(data[1]);

            return new DateTime(2000, 1, 1, hour, minute, 0);
        }


        public static EstablishmmentById To(EstablishmmentModelData data)
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

        public static UserModelDataToUser To(UserModelData userData) {

            return new UserModelDataToUser {
            
                Name = userData.Name,
                Email = userData.Email,
                Dateborn = userData.Dateborn,
                Gender = userData.Gender
                
            };

        }

    }
}
