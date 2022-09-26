﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Class2
    {
        public List<product> ShowProducts()
        {
            List<product> p = new List<product>();
            string connstring = @"Data Source=LAPTOP-TNLVFP3U\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand sq = new SqlCommand("Select * from Products", conn);
            conn.Open();
            SqlDataReader sl = sq.ExecuteReader();
            while (sl.Read())
            {
                product p1 = new product();
                p1.ProductId = Convert.ToInt32(sl[0]);
                p1.Product_Name = sl[1].ToString();
                p1.SupplierIds = Convert.ToInt32(sl[2]);
                p1.Ctegoryid = Convert.ToInt32(sl[3]);
                p1.QuantityPerunits = sl[4].ToString();
                p1.Unitcost = Convert.ToDouble(sl[5]);
                p1.Unitsonorders = Convert.ToInt32(sl[6]);
                p1.ReorderLevel = Convert.ToInt32(sl[7]);
                p1.Discontinued = Convert.ToBoolean(sl[8]);
                p.Add(p1);
            }
            conn.Close();
            return p;

        }
    }
 }   

