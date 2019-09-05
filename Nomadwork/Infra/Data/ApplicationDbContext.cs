using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Models;

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