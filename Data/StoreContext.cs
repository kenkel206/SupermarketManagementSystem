using SupermarketManagementSystem.Business;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Runtime.InteropServices;


namespace SupermarketManagementSystem
{
    public class StoreContext : DbContext
    {
        // the named connection string
        public StoreContext() : base("name=ProductContext")
        {
            Database.SetInitializer<StoreContext>(null);
        }

        // DbSets for entities
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Stockitem> Stockitems { get; set; }
        public DbSet<Catagory> Catagories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Product - Category (many-to-one)
            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Catagory)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CatagoryID);

          

            // Stockitem -> Product (one-to-one stockitem requires product)
            modelBuilder.Entity<Stockitem>()
                .HasRequired(s => s.Product)
                .WithOptional(p => p.StockItem);

            // Stockitem -> Supplier (one-to-one)
            modelBuilder.Entity<Stockitem>()
                .HasRequired(s => s.Supplier)
                .WithOptional(sup => sup.StockItem);

            base.OnModelCreating(modelBuilder);
        }
    }
}
