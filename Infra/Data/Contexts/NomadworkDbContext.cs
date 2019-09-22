using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.Model_Data;

namespace Nomadwork.Infra.Data.Contexts
{
    public class NomadworkDbContext : DbContext
    {
        public NomadworkDbContext(DbContextOptions<NomadworkDbContext> options) : base(options)
        {
        }
        public DbSet<EstablishmentModelData> Establishments { get; set; }
        public DbSet<AddressModelData> Address { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}