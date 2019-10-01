using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Repository
{
    public class UserMockup
    {
        public List<UserModelData> Init()
        => new List<UserModelData>
        {
             Create("Caio","caio@gmail.com.br","1234","05/29/2015" ),
 

        };

        private UserModelData Create(string name, string email, string password, string dateborn)
        {
            return new UserModelData
            {
                Name = name,
                Email = email,
                Password = password,
                Dateborn = dateborn

            };
        }
    }
}
