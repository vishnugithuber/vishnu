using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of Products");
            List<product> po = new List<product>();
            Class2 cq = new Class2();
            po = cq.ShowProducts();
            foreach (var item in po)
            {
                Console.Write($"{item.ProductId},{item.Product_Name},{item.SupplierIds},{item.Ctegoryid},{item.QuantityPerunits},{item.Unitcost},{item.Unitsonorders},{item.ReorderLevel},{item.Discontinued}\n");
            }
            Console.Read();

        }
    }
}
