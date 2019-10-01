using Nomadwork.Infra.Data.ObjectData;

namespace Nomadwork.Infra.Models
{
    public class UserLogin :AEntity
    {
       public string Email { get; set; } 
       public string Password { get; set; }

    }
}