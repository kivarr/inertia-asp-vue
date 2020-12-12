using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InertiaTest.WebApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.Account)
                .WithMany(a => a.Users)
                .HasForeignKey(u => u.AccountId);
            modelBuilder.Entity<Contact>().HasOne(c => c.Account)
                .WithMany(a => a.Contacts)
                .HasForeignKey(c => c.AccountId);
            modelBuilder.Entity<Organization>().HasOne(o => o.Account)
                .WithMany(a => a.Organizations)
                .HasForeignKey(o => o.AccountId);
            
            modelBuilder.Entity<Contact>().HasOne(c => c.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);

            modelBuilder.Entity<Contact>().HasQueryFilter(c => c.DeletedAt == null);
            modelBuilder.Entity<Organization>().HasQueryFilter(o => o.DeletedAt == null);
            modelBuilder.Entity<User>().HasQueryFilter(u => u.DeletedAt == null);

            FakeData.Init();
            modelBuilder.Entity<Account>().HasData(FakeData.Accounts);
            modelBuilder.Entity<User>().HasData(FakeData.Users);
            modelBuilder.Entity<Organization>().HasData(FakeData.Organizations);
            modelBuilder.Entity<Contact>().HasData(FakeData.Contacts);

            base.OnModelCreating(modelBuilder);
        }
        
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is Timestamp && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTimeOffset.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((Timestamp) entity.Entity).CreatedAt = now;
                }

                ((Timestamp) entity.Entity).UpdatedAt = now;
            }
        }
    }
}