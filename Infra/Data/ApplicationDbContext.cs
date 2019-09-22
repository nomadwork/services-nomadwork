using Microsoft.EntityFrameworkCore;
using services_nomadwork.Infra.Model;

namespace Nomadwork.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Establishment> Establishments{ get; set; }
    }
}