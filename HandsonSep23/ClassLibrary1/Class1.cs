using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class product
    {
        private int product_id;
        public int ProductId
        {
            get { return product_id; }
            set { product_id = value; }
        }
        private string product_name;
        public string Product_Name
        {
            get { return product_name; }
            set
            {
                if (value.Length < 45)
                {
                    product_name = value;
                }
                else
                {
                    throw new Exception("product name is not valid");
                }
            }
        }
        public int SupplierIds
        {
            get; set;
        }
        public int Ctegoryid
        {
            get;
            set;
        }
        private string quantity;
        public string QuantityPerunits
        {
            get { return quantity; }
            set
            {
                if (value.Length < 30)
                {
                    quantity = value;
                }
                else
                {
                    throw new Exception("Quantity is not valid");
                }
            }

        }
        public Double Unitcost
        {
            get;
            set;
        }
        public int Unitsonorders
        {
            get;
            set;
        }
        public int ReorderLevel
        {
            get;
            set;
        }
        public Boolean Discontinued
        {
            get;
            set;
        }
    }
}
