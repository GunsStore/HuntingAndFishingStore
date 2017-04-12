using System.Collections.Concurrent;

namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class Basket
    {
        public Basket()
        {
            Clothings = new HashSet<Clothing>();
            Batons = new HashSet<Baton>();
            Tazers = new HashSet<Tazer>();
            Flashlights = new HashSet<Flashlight>();
            Knives = new HashSet<Knife>();
            Scopes = new HashSet<Scope>();
            Holsters = new HashSet<Holster>();
            Firearms  = new HashSet<Firearm>();
            Rounds = new HashSet<Round>();
        }

        [Key]
        public int Id { get; set; }

        public virtual Order Order{ get; set; }

        public virtual ICollection<Clothing> Clothings { get; set; }

        public virtual ICollection<Baton> Batons { get; set; }

        public virtual ICollection<Tazer> Tazers { get; set; }

        public virtual ICollection<Flashlight> Flashlights { get; set; }

        public virtual ICollection<Knife> Knives { get; set; }

        public virtual ICollection<Scope> Scopes { get; set; }

        public virtual ICollection<Holster> Holsters { get; set; }

        public virtual ICollection<Firearm> Firearms { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }
    }
}
