using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.Business
{

    [Table("Catagory")]
    public class Catagory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CatagoryID { get; set; }

        [Required]
        [MaxLength(30)]
        public string CatagoryName { get; set; }

        // One-to-Many: Category has many Products
        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return $"{CatagoryName}: {CatagoryID}";
        }
    }

    public class CatagoryRepository
    {
        private readonly StoreContext _context;

        public CatagoryRepository(StoreContext context)
        {
            _context = context;
        }

        //linear search 


    }
}
