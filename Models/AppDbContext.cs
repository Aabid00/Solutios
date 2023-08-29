using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAbd.Models;

namespace DataAbd.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option){  }

        public DbSet<Employee> employees { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Chetu> chetus { get; set; }
        public DbSet<login> login { get; set; }
    }
}
