using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDAC_TP034903.Models
{
    public class ShipYard
    {
        [Key]
        public int ShipYardID { get; set; }
        [Required]
        public string ShipYardName { get; set; }
        [Required]
        public int CurrentNumberOfShipsDocked { get; set; }
        [Required]
        public int ShipYardDockNumber { get; set; }
        [Required]
        public int TotalNumberOfContainers { get; set; }
    }
}