using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.Business
{
    internal class StockItem
    {
        string StockID { get; set; }
        string productId { get; set; }
        int Quantity { get; set; }
        DateTime ExpiryDate { get; set; }
        int BatchNumber { get; set; }
    }
}
