using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPP23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connstring = @"Data Source=LAPTOP-TNLVFP3U\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand sq = new SqlCommand("Select * from Products101", conn);
            conn.Open();
            SqlDataReader sl = sq.ExecuteReader();
            while (sl.Read())
            {

                Console.Write($"{sl["ProductID"]},{sl["ProductName"]},{sl["UnitPrice"]}\n");
            }
            conn.Close();
            Console.Read();
        }
    }
    }

