using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookApp
{
    class Author
    {
        [Key]
        public int aid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
    }
}
