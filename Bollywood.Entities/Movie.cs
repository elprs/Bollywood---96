using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bollywood.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public double Rating { get; set; }
        public Country Country { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Duration { get; set; }  //Minutes
        public string PhotoUrl { get; set; }
        public string TrailerUrl { get; set; }

        

        public virtual ProductionCode productionCode { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
