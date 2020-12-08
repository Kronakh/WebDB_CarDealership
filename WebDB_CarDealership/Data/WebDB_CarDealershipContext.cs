using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDB_CarDealership.Models;

namespace WebDB_CarDealership.Data
{
    public class WebDB_CarDealershipContext : DbContext
    {
        public WebDB_CarDealershipContext (DbContextOptions<WebDB_CarDealershipContext> options)
            : base(options)
        {
        }

        public DbSet<WebDB_CarDealership.Models.AdditionalEquipment> AdditionalEquipment { get; set; }

        public DbSet<WebDB_CarDealership.Models.Manufacturers> Manufacturers { get; set; }

        public DbSet<WebDB_CarDealership.Models.Customers> Customers { get; set; }

        public DbSet<WebDB_CarDealership.Models.Auto> Auto { get; set; }

        public DbSet<WebDB_CarDealership.Models.BodyType> BodyType { get; set; }

        public DbSet<WebDB_CarDealership.Models.Position> Position { get; set; }

        public DbSet<WebDB_CarDealership.Models.Staff> Staff { get; set; }
    }
}
