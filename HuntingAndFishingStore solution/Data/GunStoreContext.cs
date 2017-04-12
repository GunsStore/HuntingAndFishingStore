using Data.EntityConfiguration;

namespace Data
{
    using Models;
    using System.Data.Entity;

    public class GunStoreContext : DbContext
    {
        public GunStoreContext()
            : base("name=GunStoreContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<GunStoreContext>());
        }
        
        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Baton> Batons { get; set; }

        public virtual DbSet<Clothing> Clothes { get; set; }

        public virtual DbSet<Firearm> Firearms { get; set; }

        public virtual DbSet<Flashlight> Flashlights { get; set; }

        public virtual DbSet<Holster> Holsters { get; set; }

        public virtual DbSet<Knife> Knives { get; set; }

        public virtual DbSet<Round> Rounds { get; set; }

        public virtual DbSet<Scope> Scopes { get; set; }

        public virtual DbSet<Tazer> Tazers { get; set; }

        public virtual DbSet<Basket> Baskets { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Payment> Payments { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}