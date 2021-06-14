using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie6.Models;

namespace RazorPagesMovie6.Data
{
    public class RazorPagesMovie6Context : DbContext
    {
        public RazorPagesMovie6Context (DbContextOptions<RazorPagesMovie6Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie6.Models.Movie> Movie { get; set; }
    }
}
