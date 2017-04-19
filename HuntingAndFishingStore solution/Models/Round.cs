using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Round
    {
        public Round()
        {
            this.Firearms = new HashSet<Firearm>();
            BasketRounds = new HashSet<BasketRound>();
        }

        public int Id { get; set; }

        public byte[] Image { get; set; }

        public double Caliber { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }

        public virtual Category Category { get; set; }
        
        public int CategoryId { get; set; }

        public ICollection<Firearm> Firearms { get; set; }

        public virtual ICollection<BasketRound> BasketRounds { get; set; }

    }
}
