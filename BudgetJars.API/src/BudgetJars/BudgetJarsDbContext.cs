using BudgetJars.API.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BudgetJars.API
{
    public class BudgetJarsDbContext : DbContext
    {
        public BudgetJarsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Jar> Jars { get; set; }

        public DbSet<Income> Incomes { get; set; }

        public DbSet<Outcome> Outcomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
               .Entity<User>()
               .HasKey(x => x.Id);

            modelBuilder
                .Entity<User>()
                .HasMany(x => x.Jars)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Entity<User>()
                .HasMany(x => x.Incomes)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Entity<User>()
                .HasMany(x => x.Outcomes)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Entity<Jar>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<Jar>()
                .HasMany(x => x.Outcomes)
                .WithOne(x => x.Jar)
                .HasForeignKey(x => x.JarId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Entity<Income>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<Outcome>()
                .HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
