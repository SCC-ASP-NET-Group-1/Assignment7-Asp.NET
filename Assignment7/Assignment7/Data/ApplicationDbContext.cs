using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment7.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Assignment7.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Listing> Listings { get; set; }
    }
}
