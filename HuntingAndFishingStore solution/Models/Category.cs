using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public Category()
        {
            Batons = new HashSet<Baton>();
            Firearms = new HashSet<Firearm>();
            Holsters = new HashSet<Holster>();
            Flashlights = new HashSet<Flashlight>();
            Rounds = new HashSet<Round>();
            Clothings = new HashSet<Clothing>();
            Knives = new HashSet<Knife>();
        }
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Baton> Batons { get; set; }
        public virtual ICollection<Firearm> Firearms { get; set; }
        public virtual ICollection<Holster> Holsters { get; set; }
        public virtual ICollection<Flashlight> Flashlights { get; set; }
        public virtual  ICollection<Round> Rounds { get; set; }
        public virtual ICollection<Clothing> Clothings { get; set; }
        public virtual ICollection<Knife> Knives { get; set; }
        public virtual ICollection<Scope> Scopes { get; set; }
        public virtual ICollection<Tazer> Tazers { get; set; }


    }
}
