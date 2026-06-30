using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace SupermarketManagementSystem.Business
{
    [Table("Stockitem")]
    public class Stockitem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockID { get; set; }

        // Foreign key to Product
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
        public int BatchNumber { get; set; }
        public DateTime ExpiryDate { get; set; }

        // Foreign key to Supplier
        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }

        public override string ToString()
        {
            return $"{ProductID}:{ExpiryDate},{StockID}";
        }
    }
}
