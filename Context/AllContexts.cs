using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GalkinEx.Models;

namespace GalkinEx.Context
{
    public class AllContexts : DbContext
    {
        public DbSet<employees> employees { get; set; }
        public DbSet<material> material { get; set; }
        public DbSet<materialType> materialType { get; set; }
        public DbSet<orders> orders { get; set; }
        public DbSet<partners> partners { get; set; }
        public DbSet<partnersProducts> partnersProducts { get; set; }
        public DbSet<product> product { get; set; }
        public DbSet<production> production { get; set; }
        public DbSet<productType> productType { get; set; }

        public AllContexts()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.Connection.config, Config.Connection.mySqlServerVersion);
        }
    }
}
