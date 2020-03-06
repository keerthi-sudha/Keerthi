using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Book
    {
        [Key]
        public int bid { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public virtual ICollection<Detail> Details { get; set; }

    }
}
