using SupermarketManagementSystem.Business;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Runtime.InteropServices;


namespace SupermarketManagementSystem
{
    public class StoreContext : DbContext
    {
        // the named connection string
        {
            Database.SetInitializer<StoreContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Stockitem> Stockitems { get; set; }

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
