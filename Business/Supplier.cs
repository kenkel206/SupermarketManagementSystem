using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketManagementSystem.Business
{
    [Table("supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        [Required]
        [MaxLength(30)]

        public String SupplierName { get; set; }
        [Required]
        [MaxLength(30)]

        public int PhoneNumber { get; set; }
        [Required]
        [MaxLength(11)]

        public String EmailAddress { get; set; }

        // One-to-One with StockItem
        public virtual Stockitem StockItem { get; set; }

        public override string ToString()
        {
            return $"{SupplierName}: {PhoneNumber},{EmailAddress}";
        }

        //add 

        //remove

        //update

        //linear search 

    }

}
