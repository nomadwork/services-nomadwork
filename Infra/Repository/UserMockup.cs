using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Nomadwork.ViewObject.Shared.Enum;

namespace Nomadwork.Infra.Repository
{
    public class UserMockup
    {
        
        public UserModelData Init()
            => Create("Caio", "caio@gmail.com.br", "1234", new DateTime(2019, 12, 31), Gender.Male );

        private UserModelData Create(string name, string email, string password, DateTime dateborn, Gender gender)
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
