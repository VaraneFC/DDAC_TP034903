using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDAC_TP034903.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        [Required]
        public int ShipID { get; set; }
        [Required]
        public int ContainerID { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Destination { get; set; }
    }
}