
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NomadWork.Api.ModelsDatabase
{
    [Table("User")]

    public class UserDb
    {
        [Required, Column(TypeName = "char(6)"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string NumberPhone { get; set; }

        [Required, Column(TypeName = "varchar(30)")]
        public string UserName { get; set; }

        [Required, Column(TypeName = "varchar(40)")]
        public string Password { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        public bool Active { get; set; }

        [Required]
        public AddressModel Address { get; set; }
    }
}
