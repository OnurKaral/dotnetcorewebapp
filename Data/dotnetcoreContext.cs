using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnetcore.Models;

namespace dotnetcore.Data
{
    public class dotnetcoreContext : DbContext
    {
        public dotnetcoreContext (DbContextOptions<dotnetcoreContext> options)
            : base(options)
        {
        }

        public DbSet<dotnetcore.Models.Movie> Movie { get; set; }
    }
}
