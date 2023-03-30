using GolfManager.Domain.Common;
using GolfManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GolfManager.Infrastructure.Persistence.Data
{
    public class GolfManagerContext : DbContext
    {
        public GolfManagerContext(DbContextOptions<GolfManagerContext> options) : base(options)
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<EventCustomer> EventCustomers { get; set; }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<Audit>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;

                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
