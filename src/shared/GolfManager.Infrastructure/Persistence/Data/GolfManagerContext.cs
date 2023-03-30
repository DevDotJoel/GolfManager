using GolfManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
