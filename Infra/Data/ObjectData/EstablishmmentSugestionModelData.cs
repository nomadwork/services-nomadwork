using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.ObjectData
{
    [Table("Establishimment_Sugestions")]
    public class EstablishmmentSugestionModelData  :AEntity
    {
        [Required, Column(TypeName = "varchar(100)")]
        public string Name { get; set; }


        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }


        public DateTime TimeOpen { get; set; }


        public DateTime TimeClose { get; set; }

        [Required]
        public short Wifi { get; set; }

        [Required]
        public short Noise { get; set; }

        [Required]
        public short Plug { get; set; }

        [Required, Column(TypeName = "decimal(12,9)")]
        public decimal Latitude { get; set; }


        [Required, Column(TypeName = "decimal(12,9)")]
        public decimal Longitude { get; set; }
    }
}
