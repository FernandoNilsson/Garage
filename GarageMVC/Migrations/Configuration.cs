namespace GarageMVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DataAccessLayer;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.VehiclesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VehiclesContext context)

        {
            Vehicle[] vehicles = SeedVehicles(context);
            Member[] members = SeedMembers(context);

            //member = PopulateMembers(context);

        }


        private static Vehicle[] SeedVehicles(VehiclesContext context)
        {
            Vehicle[] vehicles = new[]
            {
                 new Vehicle
              {
                  RegNr = "ABC 123",
                  Color = "Blue",
                  Brand = "Volvo",
                  Model = "V70",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 15, 08, 15, 07)
              },
              new Vehicle
              {
                  RegNr = "YUI 567",
                  Color = "Green",
                  Brand = "BMW",
                  Model = "K1300S",
                  NrWheels = 2,
                  CheckInTime = new DateTime(2016, 05, 16, 10, 03, 05)
              },

              new Vehicle
              {
                  RegNr = "ERT 987",
                  Color = "Black",
                  Brand = "Scania",
                  Model = "R620",
                  NrWheels = 6,
                  CheckInTime = new DateTime(2016, 05, 17, 10, 30, 05)
              },

              new Vehicle
              {
                  RegNr = "GIJ 543",
                  Color = "Red",
                  Brand = "Porsche",
                  Model = "718 Boxter",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 17, 15, 03, 05)
              },

              new Vehicle
              {
                  RegNr = "FGH 689",
                  Color = "Blue",
                  Brand = "Tesla",
                  Model = "Model X",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 17, 18, 13, 45)
              },

              new Vehicle
              {
                  RegNr = "BDR 472",
                  Color = "White",
                  Brand = "Subaru",
                  Model = "Impreza",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 18, 06, 33, 05)
              },

              new Vehicle
              {
                  RegNr = "KLY 401",
                  Color = "Black",
                  Brand = "Ford",
                  Model = "B-Max",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 18, 07, 03, 25)
              },

              new Vehicle
              {
                  RegNr = "YWE 734",
                  Color = "Red/White",
                  Brand = "Honda",
                  Model = "NSR250R",
                  NrWheels = 2,
                  CheckInTime = new DateTime(2016, 05, 12, 07, 29, 59)
              },

              new Vehicle
              {
                  RegNr = "DPS 895",
                  Color = "Blue",
                  Brand = "Volvo",
                  Model = "FL7",
                  NrWheels = 4,
                  CheckInTime = new DateTime(2016, 05, 12, 08, 00, 05),
              }

          };
            context.Vehicles.AddOrUpdate(c => c.RegNr, vehicles);
            context.SaveChanges();
            return vehicles;
        }

        private static Member[] SeedMembers(VehiclesContext context)
        {
            Member[] members = new[] {
                new Member { Name = "Andrew Peters", PersonalNr = ""},
                new Member { Name = "Brice Lambson", PersonalNr = ""},
                new Member { Name = "Rowan Miller", PersonalNr = ""},
                new Member { Name = "Linda Thatcher", PersonalNr =""},
                new Member { Name = "Anne Reasoner", PersonalNr = ""}
            };
            context.Members.AddOrUpdate(s => s.Name, members);
            context.SaveChanges();
            return members;
        }

        private static VehicleType[] SeedVehicleTypes(VehiclesContext context)
        {
            VehicleType[] vehicleTypes = new[] {
                new VehicleType { Type = "Car" },
                new VehicleType { Type = "Motorcycle"},
                new VehicleType { Type = "Truck"}

            };
            context.VehicleTypes.AddOrUpdate(s => s.Name, vehicleTypes);
            context.SaveChanges();
            return vehicleTypes;
        }
    }
}

