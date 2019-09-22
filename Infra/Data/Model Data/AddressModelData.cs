using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.Model_Data
{
    [Table("Address")]
    public class AddressModelData : AEntity
    {
        [Column(TypeName = "varchar(15)")]
        public string Zipcode { get; set; }


        [Required, Column(TypeName = "varchar(100)")]
        public string Street { get; set; }


        [Required, Column(TypeName = "varchar(10)")]
        public string Number { get; set; }


        [Required, Column(TypeName = "varchar(30)")]
        public string Coutry { get; set; }


        [Required, Column(TypeName = "varchar(30)")]
        public string State { get; set; }


        [Required, Column(TypeName = "decimal(8,8)")]
        public decimal Latitude { get; set; }


        [Required, Column(TypeName = "decimal(8,8)")]
        public decimal Longitude { get; set; }

    }
}