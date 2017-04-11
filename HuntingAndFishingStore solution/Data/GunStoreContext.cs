namespace Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GunStoreContext : DbContext
    {
        // Your context has been configured to use a 'GunStoreContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Data.GunStoreContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GunStoreContext' 
        // connection string in the application configuration file.
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
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}