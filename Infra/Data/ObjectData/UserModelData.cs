using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Data.ObjectData
{
    public class UserModelData : AEntity
    {
        [Required, Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(10)")]
        public  string Dateborn { get; set; }
    }
}
