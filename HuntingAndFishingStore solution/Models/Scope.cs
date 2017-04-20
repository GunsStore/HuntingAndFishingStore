using System.Collections.Generic;

namespace Models
{
    public class Scope
    {
        public Scope()
        {
            this.Firearms = new HashSet<Firearm>();
            BasketScopes = new HashSet<BasketScope>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Image { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
        

        public ICollection<Firearm> Firearms { get; set; }

        public virtual ICollection<BasketScope> BasketScopes { get; set; }
    }
}
