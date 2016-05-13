using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageMVC.Models
{

    public enum VehicleTypes {Car,Motorcycle,Truck }



    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleTypes VehicleType { get; set; }

        public DateTime CheckInTime { get; set; }

        [Required]
        [StringLength(10)]
        public string RegNr { get; set; }
        [Required]
        [StringLength(30)]
        public string Color { get; set; }
        [Required]
        [StringLength(40)]
        public string Brand { get; set; }
        [Required]
        [StringLength(40)]
        public string Model { get; set; }
        [Required]
        [Range(2,10)]
        public int NrWheels { get; set; }


       

    }
}