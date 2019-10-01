using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Infra.Models;

namespace Nomadwork.Infra.Data.Contexts
{
    public class NomadworkDbContext : DbContext
    {
        public NomadworkDbContext(DbContextOptions<NomadworkDbContext> options) : base(options)
        {
        }

        public DbSet<EstablishmentModelData> Establishments { get; set; }
        public DbSet<AddressModelData> Address { get; set; }
        public DbSet<PhotoModelData> Photos { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
    }
}