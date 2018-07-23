using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DDAC_TP034903.Models
{
    public class Container
    {
        [Key]
        public int ContainerID { get; set; }
        [Required]
        public string ContainerName { get; set; }
        [Required]
        public string ContainerDescription { get; set; }
        [Required]
        public int ContainerAmount { get; set; }
        [Required]
        public double ContainerWeight { get; set; }
    }
}