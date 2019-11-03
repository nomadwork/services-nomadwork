using Nomadwork.ViewObject.Shared;
using System;
using System.Collections.Generic;

namespace Nomadwork.ViewObject
{
    public class UserToDisplay
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime Dateborn { get; set; }

        public Gender Gender { get; set; }

        public bool Admin { get; set; }

        public List<EstablishmmentToListDisplay> Establishmments { get; set; } = new List<EstablishmmentToListDisplay>();
    }
}
