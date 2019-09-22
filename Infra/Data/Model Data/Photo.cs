using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.Model_Data
{
    [Table("Photos")]
    public class Photo : AEntity
    {
        [Required]
        public string UrlPhoto { get; set; }
    }
}