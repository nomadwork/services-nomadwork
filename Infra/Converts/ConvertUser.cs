using Nomadwork.Domain.User;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;
using Nomadwork.ViewObject.Shared;
using Nomadwork.ViewObject.User;

namespace Nomadwork
{
    public static class ConvertUser
    {
        public static User ToValidate(this UserToCreate user)
            => User.Create(user.Name, user.Email, user.Password, user.Dateborn.ToDate(), user.Gender.ToGender());


        public static UserToDisplay ToDisplay(this UserModelData user)
            => new UserToDisplay
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Dateborn = user.Dateborn,
                Gender = user.Gender,
                Admin = user.Admin
            };

        public static UserModelData ToUserData(this UserToUpdate user)
            => new UserModelData
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Gender = user.Gender.ToGender()
            };

        public static User ToValidate(this UserToUpdate user)
            => User.Create(user.Name,user.Email,null,user.Dateborn.ToDate(),user.Gender.ToGender());

        public static UserModelData ToUserData(this UserToCreate userToCreate)
            => new UserModelData
            {
                Name = userToCreate.Name,
                Email = userToCreate.Email,
                Password = userToCreate.Password,
                Dateborn = userToCreate.Dateborn.ToDate(),
                Gender = userToCreate.Gender.ToGender(),
                Admin = userToCreate.Admin
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
