using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.Model_Data
{
    [Table("Establishment")]
    public class EstablishmentModelData : AEntity
    {
        [Required, Column(TypeName = "varchar(100)")]
        public string Name { get; set; }


        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }



        [Column(TypeName = "varchar(20)")]
        public float Phone { get; set; }


        public DateTime TimeOpen { get; set; }

        public DateTime TimeClose { get; set; }


        public List<Photo> Photos { get; set; }


        [Required]
        public AddressModelData Address { get; set; }
    }
}