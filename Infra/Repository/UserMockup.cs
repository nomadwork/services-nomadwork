using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject.Shared;
using System;
using System.Collections.Generic;

namespace Nomadwork.Infra.Repository
{
    public static class UserMockup
    {

        public static List<UserModelData> Init()
            => new List<UserModelData> 
            { 
                Create("Caio", "caio@gmail.com.br", "1234", new DateTime(2019, 12, 31), Gender.Male),
                Create("Nomad Work", "nomadwork@gmail.com", "12345678", new DateTime(2019, 12, 31), Gender.Male),
                Create("Jerson Brito", "jerson@gmail.com", "12345", new DateTime(1987, 07, 09), Gender.Male),
            };

        private static UserModelData Create(string name, string email, string password, DateTime dateborn, Gender gender)
        {
            return new UserModelData
            {
                Name = name,
                Email = email,
                Password = password,
                Dateborn = dateborn,
                Gender = gender

            };
        }
    }
}
