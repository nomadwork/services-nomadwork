using Nomadwork.ViewObject.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.ObjectData
{
    [Table("Users")]
    public class UserModelData : AEntity
    {
        [Required, Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Password { get; set; }


        [Column(TypeName = "Date")]
        public DateTime Dateborn { get; set; }

        public Gender Gender { get; set; }

        public bool Admin { get; set; }
      
    }
}
