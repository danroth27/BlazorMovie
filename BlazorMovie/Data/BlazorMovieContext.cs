using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorMovie.Models;

namespace BlazorMovie.Data
{
    public class BlazorMovieContext : DbContext
    {
        public BlazorMovieContext (DbContextOptions<BlazorMovieContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
