using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageMVC.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}