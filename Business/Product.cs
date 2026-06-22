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
    }


}
