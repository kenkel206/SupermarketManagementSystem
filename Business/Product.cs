using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.Business
{
    internal class Product
    {
        String ProductID { get; set; }
        String ProductName { get; set; }
        double CostPrice { get; set; }
        long barcode { get; set; }
        int TaxRate { get; set; }
        string CategoryID { get; set; }
        
        string Brandunit { get; set; }
        double sellingPrice { get; set; }


    }
}
