using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.Entities;
using System.Net;
using System.Reflection;

namespace SportMonitorAPI.AppContext
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        protected readonly IConfiguration Configuration;
        public ApplicationContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Game>? Games { get; set; }
        public DbSet<GamePerformance>? GamePerformances { get; set; }
        public DbSet<Measurement>? Measurements { get; set; }
        public DbSet<MeasurementTaken>? MeasurementTakens { get; set; }
        public DbSet<PhysichalTest>? PhysichalTests { get; set; }
        public DbSet<Player>? Players { get; set; }
        public DbSet<TestTaken>? TestTakens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Player", NormalizedName = "PLAYER"},
                new IdentityRole { Name = "Member", NormalizedName = "MEMBER" }
                );
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
