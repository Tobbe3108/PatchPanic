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

        public DbSet<CategoriesModel> CategoriesModels { get; set; }
        public DbSet<CategoryFieldsModel> CategoryFieldsModels { get; set; }
        public DbSet<EntitiesModel> EntitiesModels { get; set; }
        public DbSet<EntityDependenciesModel> EntityDependenciesModels { get; set; }
        public DbSet<EntityEntriesModel> EntityEntriesModels { get; set; }
        public DbSet<TasksModel> TasksModels { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Settings.Default.AzureDB);
        }
    }
}
