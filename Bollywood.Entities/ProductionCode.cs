using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bollywood.Entities
{
   public class ProductionCode
    {
        [ForeignKey("Movie")]
        public int Id { get; set; }
        public string Number { get; set; } // AT-123456

        public virtual Movie Movie { get; set; }
    }
}
