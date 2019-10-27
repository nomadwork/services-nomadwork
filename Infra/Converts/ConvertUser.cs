using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;
using Nomadwork.ViewObject.Shared;
using System;

namespace Nomadwork.Infra.Converts
{
    public static class ConvertUser
    {

        public static UserToDisplay ToDisplay(this UserModelData user)
            => new UserToDisplay
            {
                Name = user.Name,
                Email = user.Email,
                Dateborn = user.Dateborn,
                Gender = user.Gender
            };


        public static UserModelData ToUser(this UserToCreate userToCreate)
            => new UserModelData
            {
                Name = userToCreate.Name,
                Email = userToCreate.Email,
                Password = userToCreate.Password,
                Dateborn = userToCreate.Dateborn.ToDate(),
                Gender = userToCreate.Gender.ToGender()
            };


       
        public static Gender ToGender(this int id)
        {
            Gender gender;
            switch (id)
            {
                case 0:
                    gender = Gender.Male;
                    break;

                case 1:
                    gender = Gender.Female;
                    break;

                default:
                    gender = Gender.Others;
                    break;
            }

            return gender;
        }

    }
}
