﻿namespace Nomadwork.ViewObject
{
    public class UserToCreate
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Dateborn { get; set; }

        public int Gender { get; set; }
        public bool Admin { get; set; }
    }
}
