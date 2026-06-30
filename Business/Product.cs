using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketManagementSystem.Business
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProductID { get; set; }
        [Required]
        [MaxLength(30)]
        public String ProductName { get; set; }
        [Required]
        [MaxLength(30)]

        public double CostPrice { get; set; }
        [Required]
        [MaxLength(5)]

        public long barcode { get; set; }
        [Required]
        [MaxLength(13)]

        public double taxrate { get; set; }
        [Required]
        [MaxLength(5)]

        public double sellingPrice { get; set; }

        public override string ToString()
        {
            return $"{ProductName} : {sellingPrice}";

        }

    //CRUD operations
    public async Task<Product> GetByIDAsync(int id)
        {
            return await _context.Products
                .Include(b => b.Catagory)
                .FirstOrDefaultAsync(b => b.ProductID == id);
        }

    //add 
    public async Task AddAsync(Product product)
        {
            await _context.Products.addAsync(product);
            await _context.SaveChangesAsync();
        }

    //remove

    //update

    //linear search 

    public class ProductSearch
    {
        public int LinearSearch(int[] arr,int key)
        {
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == key) return i;
            }
            return -1;
        }
    
    }


}
