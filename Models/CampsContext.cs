using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamperProject.Models
{
    public class CampsContext:DbContext
    {
        public CampsContext(DbContextOptions<CampsContext> options) : base(options)
        {

        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Camp> Camp { get; set; }
    }
}
