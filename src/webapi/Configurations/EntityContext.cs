using Microsoft.EntityFrameworkCore;
using webapi.Modules;

namespace webapi.Configurations
{
    public class EntityContext : DbContext
    {
        public DbSet<Status> Status { get; set; }

        public EntityContext(DbContextOptions options) : base(options)
        { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedStatus(modelBuilder);
        }

        private void SeedStatus(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status(1, "Activo"),
                new Status(2, "Deactivo"),
                new Status(3, "Cancelado"),
                new Status(4, "In Progress"),
                new Status(5, "Paused"),
                new Status(6, "Completed"),
                new Status(7, "Asigned"),
                new Status(8, "Pending")
            );
        }
    }
}