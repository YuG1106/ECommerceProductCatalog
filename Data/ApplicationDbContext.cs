﻿using ECommerceProductCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ECommerceProductCatalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
