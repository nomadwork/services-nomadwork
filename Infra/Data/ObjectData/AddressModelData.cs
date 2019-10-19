using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.ObjectData
{
    [Table("Address")]
    public class AddressModelData : AEntity
    {
        [Column(TypeName = "varchar(15)")]
        public string Zipcode { get; set; }


        [ Column(TypeName = "varchar(200)")]
        public string Street { get; set; }


        [Column(TypeName = "varchar(10)")]
        public string Number { get; set; }


        [ Column(TypeName = "varchar(30)")]
        public string Coutry { get; set; }


        [ Column(TypeName = "varchar(30)")]
        public string State { get; set; }


        [Required, Column(TypeName = "decimal(12,9)")]
        public decimal Latitude { get; set; }


        [Required, Column(TypeName = "decimal(12,9)")]
        public decimal Longitude { get; set; }


        [Required, Column(TypeName = "decimal(3,1)")]
        public decimal LatitudePrecision { get; set; }


        [Required, Column(TypeName = "decimal(3,1)")]
        public decimal LongitudePricision { get; set; }

    }
}