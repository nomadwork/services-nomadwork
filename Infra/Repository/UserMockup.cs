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
                Create("Caio", "caio@gmail.com", "123456", new DateTime(2019, 12, 31), Gender.Male),
                Create("Nomad Work", "nomadwork@gmail.com", "123456", new DateTime(2019, 12, 31), Gender.Male),
                Create("Jerson Brito", "jerson@gmail.com", "123456", new DateTime(1987, 07, 09), Gender.Male),
                Create("Flacio Macedo", "flavio@gmail.com", "123456", new DateTime(1985, 06, 06), Gender.Male),
                Create("Pedro Chiappeta", "pedro@gmail.com", "123456", new DateTime(1992, 06, 06), Gender.Male),
                Create("Everton Nascimento", "everton@gmail.com", "123456", new DateTime(1992, 06, 06), Gender.Male),
            };

        private static UserModelData Create(string name, string email, string password, DateTime dateborn, Gender gender)
        {
            return new UserModelData
            {
                Name = name,
                Email = email,
                Password = password,
                Dateborn = dateborn,
                Gender = gender,
                

            };
        }
    }
}
