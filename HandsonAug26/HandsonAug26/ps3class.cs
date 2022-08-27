using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonAug26
{
    internal class product
    {
		private int _productID;
		
		public int ProductID
		{
			get { return _productID; }
			set { _productID = value; }
		}
		private string _productname;

		public string Productname
		{
			get { return _productname; }
			set { _productname = value; }
		}


	}
}
