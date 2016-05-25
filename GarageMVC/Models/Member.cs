﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageMVC.Models
{
    public class Member

    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [StringLength(12)]
        public string PersonalNr { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}