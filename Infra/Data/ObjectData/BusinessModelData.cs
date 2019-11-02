using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.ObjectData
{
    [Table("User_Establishmment")]
    public class BusinessModelData : AEntity
    {
        [Required]
        public UserModelData User { get; set; }

        [Required]
        public List<EstablishmmentModelData> Establishmments { get; set; }
    }
}
