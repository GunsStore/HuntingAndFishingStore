using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Firearm
    {
        public Firearm()
        {
            this.Rounds = new HashSet<Round>();
            this.Scopes = new HashSet<Scope>();
            BasketFirearms = new HashSet<BasketFirearm>();
        }

        public int Id { get; set; }
        
        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Model { get; set; }
        public int Quantity { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }

        public virtual ICollection<Scope> Scopes { get; set; }

        public virtual ICollection<BasketFirearm> BasketFirearms { get; set; }


    }
}
