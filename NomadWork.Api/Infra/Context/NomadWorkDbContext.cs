using Microsoft.EntityFrameworkCore;
using NomadWork.Api.ModelsDatabase;


namespace NomadWork.Api.Context
{
    public class NomadWorkDbContext : DbContext
    {
        public NomadWorkDbContext(DbContextOptions<NomadWorkDbContext> options) : base(options)
        {
        }
        public DbSet<AddressModel> Address { get; set; }
        public DbSet<UserDb> User { get; set; }
        public DbSet<EstablishmmentDb> Establishmment { get; set; }
    }
}
