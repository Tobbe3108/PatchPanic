using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace PatchPanic.DAL
{
    class PatchPanicContext : DbContext
    {
        public PatchPanicContext() : base() { }

        public PatchPanicContext(DbContextOptions<PatchPanicContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryField> CategoryFields { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<EntityDependency> EntityDependencies { get; set; }
        public DbSet<EntityEntry> EntityEntries { get; set; }
        public DbSet<Task> Tasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.Default.AzureDB);
        }
    }
}
