﻿using WebTabanlıProgramlama_1ODEV.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebTabanlıProgramlama_1ODEV.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}



