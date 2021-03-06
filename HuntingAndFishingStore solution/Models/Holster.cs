﻿using System.Collections.Generic;

namespace Models
{
    public class Holster
    {
        public Holster()
        {
            this.Firearms = new HashSet<Firearm>();
            BasketHolsters = new HashSet<BasketHolster>();
        }

        public int Id { get; set; }

        public byte[] Image { get; set; }
        

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Firearm> Firearms { get; set; }

        public virtual ICollection<BasketHolster> BasketHolsters { get; set; }

    }
}
