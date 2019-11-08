using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace PatchPanic.DAL
{
    class SpikeContext : DbContext
    {
        public SpikeContext() : base() { }

        public SpikeContext(DbContextOptions<SpikeContext> options) : base(options) { }

        public DbSet<SpikeModel> SpikeModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString);
            optionsBuilder.UseSqlServer("Server = tcp:tobbeware.database.windows.net,1433; Initial Catalog = TobbeWare; Persist Security Info = False; User ID = Tobbe; Password = 79IufLyBiMsn28; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
        }
    }
}
