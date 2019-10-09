using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.ViewObject
{
    public class UserCreateToUserModelData
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Dateborn { get; set; }

        public int Gender { get; set; }
    }
}
