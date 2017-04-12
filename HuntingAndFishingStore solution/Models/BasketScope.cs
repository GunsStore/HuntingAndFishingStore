using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BasketScope
    {
        [Key, Column(Order = 0)]
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        [Key, Column(Order = 1)]
        public int ScopeId { get; set; }
        public Scope Scope { get; set; }
        public int Quantity { get; set; }
    }
}
