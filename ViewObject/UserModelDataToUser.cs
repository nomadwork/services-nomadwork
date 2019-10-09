using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Nomadwork.ViewObject.Shared.Enum;

namespace Nomadwork.ViewObject
{
    public class UserModelDataToUser
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Dateborn { get; set; }

        public Gender Gender { get; set; }
    }
}
