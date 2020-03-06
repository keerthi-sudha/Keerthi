using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_codefirst_03
{
    class Customer
    {
        [Key]
        public int Cid { get; set; }
        [Required]
        public string Cname { get; set; }
        [MaxLength(250)]
        public string Cadress { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }

    }
}
