using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context
{
    public class OTContext : DbContext
    {
        public OTContext(DbContextOptions o) : base(o)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
