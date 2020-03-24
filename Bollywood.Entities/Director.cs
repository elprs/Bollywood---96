using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bollywood.Entities
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Country Country { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime DateOfBirth { get; set; }



        public virtual ICollection<Movie> Movies { get; set; }
    }
}
