using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.API.Models;

namespace Movie.API.Data
{
    public class MovieAPIContext : DbContext
    {
        public MovieAPIContext (DbContextOptions<MovieAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.API.Models.Movie> Movie { get; set; }
    }
}
