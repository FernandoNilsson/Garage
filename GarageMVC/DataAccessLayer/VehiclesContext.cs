using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GarageMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using GarageMVC.DataAccessLayer;
using System.Data.Entity.Migrations;

namespace GarageMVC.DataAccessLayer
{
    public class VehiclesContext : DbContext
    {
        public VehiclesContext()
            : base("GarageConnection")
        {

        }

        public DbSet<Models.Vehicle> Vehicles { get; set; }
        public DbSet<Models.VehicleType> Members { get; set; }
        public DbSet<Models.VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    
    }

}
