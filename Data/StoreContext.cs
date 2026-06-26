using SupermarketManagementSystem.Business;
using System.Data.Entity;


namespace SupermarketManagementSystem
{
    public class StoreContext : DbContext
    {
        // the named connection string
        public StoreContext() : base("name=(localdb)\\MSSQLLocalDB")
        {
            Database.SetInitializer<StoreContext>(null);
        }

        //  DbSets for  entities 

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Stockitem> Stockitems { get; set; }
        public DbSet<Catagory> catagories { get; set; }

      

    }
}
