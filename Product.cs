using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.Business
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(30)]
        public string ProductName { get; set; }

        public double CostPrice { get; set; }

        public long Barcode { get; set; }

        public double TaxRate { get; set; }

        public double SellingPrice { get; set; }

        // Foreign key to Category
        public int CatagoryID { get; set; }
        [ForeignKey("CatagoryID")]
        public virtual Catagory Catagory { get; set; }

        // One-to-one with Stockitem
        public virtual Stockitem StockItem { get; set; }

        // One-to-many: product can have multiple stock entries 
        public virtual ICollection<Stockitem> StockItems { get; set; }

        public override string ToString()
        {
            return $"{ProductName} : {SellingPrice}";
        }
    }

    // Repository pattern implementation
    public class ProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        //CRUD operations

        //get all
        public async Task<List<Product>> GetAllAsync() 
        {
            return await _context.Products
                .Include(p => p.Catagory)
                .Include(p => p.StockItem)
                .OrderBy(p => p.ProductName).ToListAsync();
        }

        //get by the id
        public Product GetById(int id)
        {
            return _context.Products.Find(id); 
        }


        //add product
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            Console.WriteLine(product.ProductName + "has been added");
        }

        //update product
        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            Console.WriteLine(product.ProductName + "has been updated");
        }

        //Delete product
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return;
            _context.Products.Remove(product);
            _context.SaveChanges();
            Console.WriteLine(product.ProductName + "has been deleted");

        }


        // linear search
        public class ProductSearch
        {
            public int LinearSearch(int[] arr, int key)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == key) return i;
                }
                return -1;
            }
        }
    }

}
