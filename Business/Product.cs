using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using System.Threading.Tasks;


namespace SupermarketManagementSystem.Business
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ProductID { get; set; }
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

        public double taxRate { get; set; }
        [Required]
        [MaxLength(5)]

        public double sellingPrice { get; set; }
        public override string ToString()
        {
            return $"{ProductName} : {sellingPrice}";
        }
    }
    //Repository pattern implentation

    
    public class productRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public productRepository(ProductContext context)
        {
            _context = context;
        }

    }
  
    //CRUD operations
   
    //add 
   
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
