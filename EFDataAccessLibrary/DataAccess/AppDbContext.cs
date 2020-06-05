using System;
using System.Collections.Generic;
using System.Text;
using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<DccuInfo> Dccus { get; set; }
        public DbSet<DiscInfo> Discs { get; set; }
    }
}
