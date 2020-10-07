using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value { id = 1, name = "Values 101" },
                    new Value { id = 2, name = "Values 102" },
                    new Value { id = 3, name = "Values 103" }
                );
        }
    }
}
