using Microsoft.EntityFrameworkCore;
using JWTproject.Domain.Entities;

namespace JWTProject.Persistance.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       
        public DbSet<Weather> Weathers { get; set; }
    }
}
