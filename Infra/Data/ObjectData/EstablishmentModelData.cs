using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.ObjectData
{
    [Table("Establishment")]
    public class EstablishmentModelData : AEntity
    {
        [Required, Column(TypeName = "varchar(100)")]
        public string Name { get; set; }


        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string Phone { get; set; }


        [Column(TypeName = "char(5)")]
        public string TimeOpen { get; set; }


        [Column(TypeName = "char(5)")]
        public string TimeClose { get; set; }

        [Required]
        public short Wifi { get;  set; }

        [Required]
        public short Noise { get;  set; }

        [Required]
        public short Plug { get;  set; }

        public List<PhotoModelData> Photos { get; set; }


        [Required]
        public AddressModelData Address { get; set; }
    }
}