using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bollywood.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Kind { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
