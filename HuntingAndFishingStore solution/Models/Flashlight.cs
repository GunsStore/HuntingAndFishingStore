using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Flashlight
    {
        public Flashlight()
        {
            BasketFlashlights = new HashSet<BasketFlashlight>();
        }

        public int Id { get; set; }

        public byte[] Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string BatteryType { get; set; }
        public int Quantity { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<BasketFlashlight> BasketFlashlights { get; set; }

    }
}
