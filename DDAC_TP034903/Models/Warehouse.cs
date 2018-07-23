using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDAC_TP034903.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseID { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public string Supervisor { get; set; }
        [Required]
        public int NumberOfContainerStored { get; set; }
    }
}