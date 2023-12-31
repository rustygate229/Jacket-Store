﻿using Jacket_Store.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Jacket_Store.DAL
{
    public class JacketContext : DbContext
    {
        // Constructor
        public JacketContext(DbContextOptions<JacketContext> options) : base(options) { }

        // DbSets
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseProduct> WarehouseProducts { get; set; }

    }

}
