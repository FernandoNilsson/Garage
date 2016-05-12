using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GarageMVC.DataAccessLayer
{
    public class VehiclesContext : DbContext
    {
        public VehiclesContext()
            :base("GarageConnection")
        {

        }

        public DbSet<Models.Vehicle> Vehicles { get; set; }
    }
}