using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public String CatagoryName { get; set; }
        [Required]
        [MaxLength(30)]
        public virtual Product Product { get; set; }

        public override string ToString()
        {
            return $"{CatagoryName}: {CatagoryID}";
        }
        //add 

        //remove

        //update

        //linear search 

    }
}
