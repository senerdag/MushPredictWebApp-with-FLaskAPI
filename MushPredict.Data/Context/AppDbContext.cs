using Microsoft.EntityFrameworkCore;
using MushPredict.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Data.Context
{
    public class AppDbContext : DbContext
    {

        protected AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Species> Species { get; set; }
    }
}
