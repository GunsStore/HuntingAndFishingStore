using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Knife
    {
        public Knife()
        {
            Baskets = new HashSet<Basket>();    
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }
    }
}
