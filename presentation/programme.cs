using SupermarketManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.presentation
{
    class programme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supermarket System");

            Console.WriteLine("what would you like to access?:");
            Console.WriteLine("A.Products");
            Console.WriteLine("B.Catagory");
            Console.WriteLine("C.StockItems");
            Console.WriteLine("D.Supplier");
            Console.ReadLine();





            if (Console.ReadLine() == "A")
            {
                Console.WriteLine("Welcome to the products section:");
                Console.WriteLine("A.add Product");
                Console.WriteLine("B.update Product");
                Console.WriteLine("C.Delete Product");
                Console.WriteLine("D.Search for product");
                Console.ReadLine();

                if (Console.ReadLine() == "A")
                {
                    var product = new Product();
                    

                }
                else if(Console.ReadLine() == "B")
                {

                }
                else if (Console.ReadLine() == "C")
                {

                }
                else if (Console.ReadLine() == "D")
                {

                }
               /*
                else  (exit)
                {

                }
               */
            }
        }
    }
}