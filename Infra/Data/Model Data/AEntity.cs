using System.ComponentModel.DataAnnotations;

namespace Nomadwork.Infra.Data.Model_Data
{
    public abstract class AEntity
    {
        // [Key, Column(TypeName = "char(6)"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        // public string Id
        // {
        //     get => Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6).ToUpper();
        //     set;
        // }
        [Key]
        public long Id { get; set; }

        public bool Active { get; set; }
    }
}