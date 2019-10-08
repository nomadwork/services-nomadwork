using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.ViewObject
{
    public class TokenCreateGetUser
    {
        public TokenCreateGetUser(object token, UserModelDataToUser user) {


            
            this.Token = token;
            this.User = user;
        }

        public object Token { get; private set; }
        public UserModelDataToUser User { get; private set; }
    }
}
