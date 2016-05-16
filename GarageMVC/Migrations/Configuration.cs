namespace GarageMVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GarageMVC.DataAccessLayer.VehiclesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GarageMVC.DataAccessLayer.VehiclesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Vehicles.AddOrUpdate(
              p => p.VehicleType,
              new Vehicle
              {
                  VehicleType = VehicleTypes.Car,
                  RegNr = "ABC 123",
                  Color = "Blue",
                  Brand = "Volvo",
                  Model = "V70",
                  NrWheels = 4,
                  CheckInTime = DateTime.Now
              },
              new Vehicle
              {
                  VehicleType = VehicleTypes.Motorcycle,
                  RegNr = "YUI 567",
                  Color = "Green",
                  Brand = "BMW",
                  Model = "K1300S",
                  NrWheels = 2,
                  CheckInTime = new DateTime(2016, 04, 15, 12, 03, 05)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Truck,
                  RegNr = "ERT 987",
                  Color = "Black",
                  Brand = "Scania",
                  Model = "R620",
                  NrWheels = 6,
                  CheckInTime = new DateTime(2016, 05, 12, 15, 03, 05)
              }


              

         
            );

        }
    }
}
