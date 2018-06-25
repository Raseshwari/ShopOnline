using Microsoft.EntityFrameworkCore;
using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Data
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }

        public DbSet<LipColor> LipColor { get; set; }
    }
}
