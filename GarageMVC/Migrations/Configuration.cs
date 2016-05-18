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
              p => p.RegNr,
              new Vehicle
              {
                  VehicleType = VehicleTypes.Car,
                  RegNr = "ABC 123",
                  Color = "Blue",
                  Brand = "Volvo",
                  Model = "V70",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 15, 08, 15, 07)
              },
              new Vehicle
              {
                  VehicleType = VehicleTypes.Motorcycle,
                  RegNr = "YUI 567",
                  Color = "Green",
                  Brand = "BMW",
                  Model = "K1300S",
                  NrWheels = 2,
                  CheckInTime = new DateTime(2016, 05, 16, 10, 03, 05)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Truck,
                  RegNr = "ERT 987",
                  Color = "Black",
                  Brand = "Scania",
                  Model = "R620",
                  NrWheels = 6,
                  CheckInTime = new DateTime(2016, 05, 17, 10, 30, 05)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Car,
                  RegNr = "GIJ 543",
                  Color = "Red",
                  Brand = "Porsche",
                  Model = "718 Boxter",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 17, 15, 03, 05)
              },
              
              new Vehicle
              {
                  VehicleType = VehicleTypes.Car,
                  RegNr = "FGH 689",
                  Color = "Blue",
                  Brand = "Tesla",
                  Model = "Model X",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 17, 18, 13, 45)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Car,
                  RegNr = "BDR 472",
                  Color = "White",
                  Brand = "Subaru",
                  Model = "Impreza",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 18, 06, 33, 05)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Car,
                  RegNr = "KLY 401",
                  Color = "Black",
                  Brand = "Ford",
                  Model = "B-Max",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 18, 07, 03, 25)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Motorcycle,
                  RegNr = "YWE 734",
                  Color = "Red/White",
                  Brand = "Honda",
                  Model = "NSR250R",
                  NrWheels = 2,
                  CheckInTime = new DateTime(2016, 05, 12, 07, 29, 59)
              },

              new Vehicle
              {
                  VehicleType = VehicleTypes.Truck,
                  RegNr = "DPS 895",
                  Color = "Blue",
                  Brand = "Volvo",
                  Model = "FL7",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 12, 08, 00, 05),
              }
              


            );

        }
    }
}
