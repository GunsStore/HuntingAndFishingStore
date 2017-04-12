using System.Collections.Concurrent;

namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class Basket
    {
        public Basket()
        {
            BasketClothings = new HashSet<BasketClothing>();
            BatonBaskets = new HashSet<BasketBaton>();
            BasketTazers = new HashSet<BasketTazer>();
            BasketFlashlights = new HashSet<BasketFlashlight>();
            BasketKnives = new HashSet<BasketKnife>();
            BasketScopes = new HashSet<BasketScope>();
            BasketHolsters = new HashSet<BasketHolster>();
            BasketFirearms  = new HashSet<BasketFirearm>();
            BasketRounds = new HashSet<BasketRound>();
        }

        [Key]
        public int Id { get; set; }

        public virtual Order Order{ get; set; }
        public int? OrderId { get; set; }

        public decimal PriceOfAllProducts { get; set; }

        public int ProductCount { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<BasketClothing> BasketClothings { get; set; }

        public virtual ICollection<BasketBaton> BatonBaskets { get; set; }

        public virtual ICollection<BasketTazer> BasketTazers { get; set; }

        public virtual ICollection<BasketFlashlight> BasketFlashlights { get; set; }

        public virtual ICollection<BasketKnife> BasketKnives { get; set; }

        public virtual ICollection<BasketScope> BasketScopes { get; set; }

        public virtual ICollection<BasketHolster> BasketHolsters { get; set; }

        public virtual ICollection<BasketFirearm> BasketFirearms { get; set; }

        public virtual ICollection<BasketRound> BasketRounds { get; set; }
    }
}
