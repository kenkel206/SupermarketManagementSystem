using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketManagementSystem.Business
{
    [Table("Suppliers")]
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String SupplierID { get; set; }
        [Required]
        [MaxLength(30)]

        public String SupplierName { get; set; }
        [Required]
        [MaxLength(30)]

        public int PhoneNumber { get; set; }
        [Required]
        [MaxLength(30)]

        public String EmailAddress { get; set; }

        public override string ToString()
        {
            return $"{SupplierName}: {PhoneNumber},{EmailAddress}";

        }

    }

}
