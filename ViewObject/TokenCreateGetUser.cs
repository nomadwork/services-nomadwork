using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.ViewObject
{
    public class TokenCreateGetUser
    {
        public TokenCreateGetUser(string token, UserModelData user) {

            this.Token = token;
            this.User = user;
        }

        public string Token { get; private set; }
        public UserModelData User { get; private set; }
    }
}
