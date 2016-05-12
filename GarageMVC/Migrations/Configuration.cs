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
                  VehicleType = "Personbil",
                  RegNr = "ABC 123",
                  Color = "Blue",
                  Brand = "Volvo",
                  Model = "V70",
                  NrWheels = 4
              },
              new Vehicle
              {
                  VehicleType = "Motorcyckel",
                  RegNr = "YUI 567",
                  Color = "Green",
                  Brand = "BMW",
                  Model = "K1300S",
                  NrWheels = 2
              },

              new Vehicle
              {
                  VehicleType = "Lastbil",
                  RegNr = "ERT 987",
                  Color = "Black",
                  Brand = "Scania",
                  Model = "R620",
                  NrWheels = 6
              }


              

         
            );

        }
    }
}
