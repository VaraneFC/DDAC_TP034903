using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDAC_TP034903.Models
{
    public class Ship
    {
        [Key]
        public int ShipCode { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipDescription { get; set; }
        [Required]
        public int NumberofContainersCarried { get; set; }

    }
}