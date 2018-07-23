using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;

namespace DDAC_TP034903.Models
{
    public class Maersk_LineContext : DbContext
    {
        public Maersk_LineContext() : base("name=Maersk_LineContext")
        {

        }
       
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<ShipYard> ShipYards { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}