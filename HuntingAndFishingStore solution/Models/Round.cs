using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Round
    {
        public Round()
        {
            this.Firearms = new HashSet<Firearm>();
        }

        public int Id { get; set; }

        public double Caliber { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<Firearm> Firearms { get; set; }
    }
}
