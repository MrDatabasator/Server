using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class MyContext : DbContext
    {
        public MyContext()
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<tbDaemon> Daemon { get; set; }
        public DbSet<tbDestination> Destination { get; set; }
        public DbSet<tbLog> Log { get; set; }
        public DbSet<tbTask> Task { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.Configuration.ProxyCreationEnabled = false;
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            modelBuilder.Entity<tbTask>()
                .HasMany<tbDestination>(s => s.LDestination)
                .WithMany(c => c.LTask)
                .Map(cs => {
                    cs.MapLeftKey("TaskId");
                    cs.MapRightKey("DestinationId");
                    cs.ToTable("navrh_TaskDestination_v1");
                });
        }
    }
}