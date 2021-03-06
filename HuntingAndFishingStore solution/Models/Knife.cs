﻿using System.Collections.Generic;

namespace Models
{
    public class Knife
    {
        public Knife()
        {
            BasketKnives = new HashSet<BasketKnife>();
        }

        public int Id { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }
        public int Quantity { get; set; }
        

        public virtual ICollection<BasketKnife> BasketKnives { get; set; }
    }
}
