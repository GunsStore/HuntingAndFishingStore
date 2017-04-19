using System.Collections.Generic;

namespace Models
{
    public class Tazer
    {
        public Tazer()
        {
            BasketTazers = new HashSet<BasketTazer>();

        }

        public int Id { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Voltage { get; set; }
        public int Quantity { get; set; }


        public virtual ICollection<BasketTazer> BasketTazers { get; set; }
    }
}
