using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketManagementSystem.Business
{
    [Table("Stockitem")]
    public class Stockitem
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String StockID { get; set; }
        [Required]
        [MaxLength(30)]

        public String ProductID { get; set; }
        [Required]
        [MaxLength(30)]

        public int Quantity { get; set; }
        [Required]
        [MaxLength(30)]
        public int BatchNumber { get; set; }
        [Required]
        [MaxLength(30)]

        public DateTime ExpiryDate { get; set; }

        public override string ToString()
        {
            return $"{ProductID}:{ExpiryDate},{StockID}";

        }

    }
}
