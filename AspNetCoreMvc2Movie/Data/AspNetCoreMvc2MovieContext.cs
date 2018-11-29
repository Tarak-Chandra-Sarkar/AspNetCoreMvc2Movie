using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvc2Movie.Models
{
    public class AspNetCoreMvc2MovieContext : DbContext
    {
        public AspNetCoreMvc2MovieContext (DbContextOptions<AspNetCoreMvc2MovieContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreMvc2Movie.Models.Movie> Movie { get; set; }
    }
}
