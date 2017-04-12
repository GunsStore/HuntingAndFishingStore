﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Holster
    {
        public Holster()
        {
            this.Firearms = new HashSet<Firearm>();
            Baskets = new HashSet<Basket>();
        }

        public int Id { get; set; }

        public virtual Category Category { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Firearm> Firearms { get; set; }

        public virtual ICollection<Basket> Baskets { get; set; }

    }
}