using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Clothing
    {
        public Clothing()
        {
            BasketClothings = new HashSet<BasketClothing>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public char Size { get; set; }
        public int Quantity { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<BasketClothing> BasketClothings { get; set; }

    }
}
