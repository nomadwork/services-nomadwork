using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.ObjectData;

namespace Nomadwork.Infra.Data.Contexts
{
    public class NomadworkDbContext : DbContext
    {
        public NomadworkDbContext(DbContextOptions<NomadworkDbContext> options) : base(options)
        {
        }

        public DbSet<EstablishmmentModelData> Establishments { get; set; }
        public DbSet<EstablishmmentSugestionModelData> EstablishmentSugestions { get; set; }
        public DbSet<AddressModelData> Address { get; set; }
        public DbSet<PhotoModelData> Photos { get; set; }
        public DbSet<UserModelData> Users { get; set; }

    }
}