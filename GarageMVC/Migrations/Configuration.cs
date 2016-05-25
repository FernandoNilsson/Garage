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
            //Another comment

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
                new Member { Name = "Andrew Peters", PersonalNr = "197302124592"},
                new Member { Name = "Brice Lambson", PersonalNr = "196007126523"},
                new Member { Name = "Rowan Miller", PersonalNr = "195904116511"},
                new Member { Name = "Linda Thatcher", PersonalNr ="196501084328"},
                new Member { Name = "Charles de Gaulle", PersonalNr = "189003259613"},
                new Member { Name = "Margret Thatcher", PersonalNr = "192510179848"},
                new Member { Name = "Winston Churchill", PersonalNr = "187404107394"},
                new Member { Name = "Mahatma Gandhi", PersonalNr ="186904138524"},
                new Member { Name = "Bill Gates", PersonalNr = "195502018536"},
                new Member { Name = "John M Keynes", PersonalNr = "188301186918"},
                new Member { Name = "Mikhail Gorbachev", PersonalNr = "193109057354"},
                new Member { Name = "George Orwell", PersonalNr ="190312208593"},
                new Member { Name = "Pablo Picasso", PersonalNr = "188102074772"},
                new Member { Name = "Muhammad Ali", PersonalNr = "194203256172"},
                new Member { Name = "Louis Pasteur", PersonalNr ="182212319835"},
                new Member { Name = "Charles Darwin", PersonalNr = "180907019692"},
                new Member { Name = "Per Karlsson", PersonalNr = "6904307831"},
                new Member { Name = "Svante Johnsson", PersonalNr ="194103155914"},
                new Member { Name = "Leo Tolstoy", PersonalNr = "182806257432"},
                new Member { Name = "Peter Taylor", PersonalNr = "194711318532"},
                new Member { Name = "Chris Harrison", PersonalNr ="195204128978"},
                new Member { Name = "Elvis Presley", PersonalNr = "193502318514"},
                new Member { Name = "Christopher Columbus", PersonalNr = "145108271156"},
                new Member { Name = "Roger Karlsson", PersonalNr ="197507136594"},
                new Member { Name = "Gunilla Berg", PersonalNr = "197703293027"},
                new Member { Name = "Paul McCartney", PersonalNr = "194209306597"},
                new Member { Name = "Thomas Edisson", PersonalNr ="184702288539"},
                new Member { Name = "Aung San Suu Kyi", PersonalNr = "194510146934"},
                new Member { Name = "Albert Einstein", PersonalNr = "187902137836"},
                new Member { Name = "Nils Nilsson", PersonalNr ="194911308532"},
                new Member { Name = "Jonas Helmersson", PersonalNr = "196305127351"},
                new Member { Name = "J.K. Rowling", PersonalNr = "196509241847"},
                new Member { Name = "Lisa Svensson", PersonalNr ="199312081526"},
                new Member { Name = "Pernilla Lind", PersonalNr = "193607027884"},
                new Member { Name = "Barack Obama", PersonalNr = "196103158514"},
                new Member { Name = "Richard Branson", PersonalNr ="195063293518"},
                new Member { Name = "Holger Pettersson", PersonalNr = "199304226091"},
                new Member { Name = "Fia Nilsson", PersonalNr = "199507127061"},
                new Member { Name = "Thomas Edison", PersonalNr ="1847063080411"},
                new Member { Name = "Ulla Ljung", PersonalNr = "1939051925420"},
                new Member { Name = "Patsy McBrian", PersonalNr = "194712037223"},
                new Member { Name = "Jens Eliasson", PersonalNr ="1967100385111"},
                new Member { Name = "Kalle Svensson", PersonalNr = "193501259013"},
                new Member { Name = "Anne Reasoner", PersonalNr = "195211076921"}
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
            context.VehicleTypes.AddOrUpdate(s => s.Type, vehicleTypes);
            context.SaveChanges();
            return vehicleTypes;
        }
    }
}

