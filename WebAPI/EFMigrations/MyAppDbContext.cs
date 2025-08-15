using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EFMigrations
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) { }

        // Optional: Override OnConfiguring if you want to configure the database connection directly here
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("YourConnectionString"); 
        // }
    }
}

