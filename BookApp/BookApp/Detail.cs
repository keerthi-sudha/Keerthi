using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Detail
    {
        [Key]
        public int aid { get; set; }
        public int bid { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }

    }
}
