using Tennis.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Context
{
    public class TenisContext : DbContext
    {
        public TenisContext() : base("Tenis")
        {

        }

        public DbSet<Tenis> Tenis{ get; set; }
     



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Tenis>()
                 .ToTable("Tenis");

            modelBuilder.Properties<string>()
                .Configure(x => x.HasColumnType("varchar"));
        }
    }
}
