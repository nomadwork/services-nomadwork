using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nomadwork.Infra.Data.ObjectData
{
    [Table("Photos")]
    public class PhotoModelData : AEntity
    {
        [Required]
        public string UrlPhoto { get; set; }

        public string ExtensionFile { get; set; }

        public string NameFile { get; set; }
    }
}