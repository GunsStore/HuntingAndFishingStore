using System.Collections.Generic;

namespace Models
{
    public class Baton
    {
        public Baton()
        {
            BatonBaskets = new HashSet<BasketBaton>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Image { get; set; }
        
        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Weight { get; set; }
        public int Quantity { get; set; }
        

        public virtual ICollection<BasketBaton> BatonBaskets { get; set; }
    }
}
