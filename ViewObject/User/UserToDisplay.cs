using Nomadwork.ViewObject.Shared;
using System;

namespace Nomadwork.ViewObject
{
    public class UserToDisplay
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Dateborn { get; set; }

        public Gender Gender { get; set; }
    }
}
