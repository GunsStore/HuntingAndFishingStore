using System.Collections.Generic;

namespace Models
{

    public class Clothing
    {
        public Clothing()
        {
            BasketClothings = new HashSet<BasketClothing>();
        }

        public int Id { get; set; }
        
        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public char Size { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }

        public virtual ICollection<BasketClothing> BasketClothings { get; set; }

    }
}
