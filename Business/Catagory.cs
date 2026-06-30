using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketManagementSystem.Business
{

    [Table("Catagory")]
    internal class Catagory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String CatagoryID { get; set; }


        public String CatagoryName { get; set; }

        public override string ToString()
        {
            return $"{CatagoryName}: {CatagoryID}";

        }


    }
}
