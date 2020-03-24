using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Bollywood.Entities;

namespace Bollywood.Database
{
    public class Mydatabase : DbContext
    {
        public Mydatabase() :base("Sindesmos")
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ProductionCode> ProductionCodes { get; set; }


    }
}
