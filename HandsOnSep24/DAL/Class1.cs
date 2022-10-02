using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;

namespace DAL
{
    public class DAbooks
    {
        public bool InsertBook(Books b)
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdinsert = new SqlCommand("insert into Book values(@book_no,@book_name,@authors,@pri,@cgory)", cn1);
            cmdinsert.Parameters.AddWithValue("@book_no", b.BookId);
            cmdinsert.Parameters.AddWithValue("@book_name", b.Bookname);
            cmdinsert.Parameters.AddWithValue("@authors", b.Author);
            cmdinsert.Parameters.AddWithValue("@pri", b.Price);
            cmdinsert.Parameters.AddWithValue("@cgory", b.Ctegory);
            cn1.Open();
            int j = cmdinsert.ExecuteNonQuery();
            bool status = false;
            if (j == 1)
            {
                status = true;
            }
            cn1.Close();
            cn1.Dispose();
            return status;
        }
        public bool UpdateBookNo(int n)
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdupdate = new SqlCommand("[dbo].[UpdateBooknum]", cn1);
            cmdupdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdupdate.Parameters.AddWithValue("@param1", n);
            Console.WriteLine("New Number you want to change");
            int kl = Convert.ToInt32(Console.ReadLine());
            cmdupdate.Parameters.AddWithValue("@param2", kl);
            cn1.Open();
            int ik = cmdupdate.ExecuteNonQuery();
            bool status1 = false;
            if (ik == 0) { status1 = true; }

            cn1.Close();
            cn1.Dispose();
            return status1;


        }
        public bool UpdateBookName(int n)
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdupdate = new SqlCommand("[dbo].[UpdateBooksname]", cn1);
            cmdupdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdupdate.Parameters.AddWithValue("@param1", n);
            Console.WriteLine("New Book name you want to change");
            string kl1 = Console.ReadLine();
            cmdupdate.Parameters.AddWithValue("@param2", kl1);
            cn1.Open();
            int ik = cmdupdate.ExecuteNonQuery();
            bool status1 = false;
            if (ik == 1) { status1 = true; }

            cn1.Close();
            cn1.Dispose();
            return status1;
        }
        public bool UpdateBookAuthor(int n)
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdupdate = new SqlCommand("[dbo].[UpdateBooksauthor]", cn1);
            cmdupdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdupdate.Parameters.AddWithValue("@param1", n);
            Console.WriteLine("New Author name you want to change");
            string kl1 = Console.ReadLine();
            cmdupdate.Parameters.AddWithValue("@param2", kl1);
            cn1.Open();
            int ik = cmdupdate.ExecuteNonQuery();
            bool status1 = false;
            if (ik == 1) { status1 = true; }

            cn1.Close();
            cn1.Dispose();
            return status1;
        }
        public bool UpdateBookPrice(int n)
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdupdate = new SqlCommand("[dbo].[UpdateBooksprice]", cn1);
            cmdupdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdupdate.Parameters.AddWithValue("@param1", n);
            Console.WriteLine("New Price of book you want to change");
            double kl1 = Convert.ToDouble(Console.ReadLine());
            cmdupdate.Parameters.AddWithValue("@param2", kl1);
            cn1.Open();
            int ik = cmdupdate.ExecuteNonQuery();
            bool status1 = false;
            if (ik == 1) { status1 = true; }

            cn1.Close();
            cn1.Dispose();
            return status1;

        }
        public bool UpdateBookCategory(int n)
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdupdate = new SqlCommand("[dbo].[UpdateBookscategory]", cn1);
            cmdupdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdupdate.Parameters.AddWithValue("@param1", n);
            Console.WriteLine("New Category name you want to change");
            string kl1 = Console.ReadLine();
            cmdupdate.Parameters.AddWithValue("@param2", kl1);
            cn1.Open();
            int ik = cmdupdate.ExecuteNonQuery();
            bool status1 = false;
            if (ik == 1) { status1 = true; }

            cn1.Close();
            cn1.Dispose();
            return status1;
        }
        List<Userslist> ulist = new List<Userslist>();
        List<Books> blist = new List<Books>();
        List<issued> issuelist = new List<issued>();
        public void issuelists()
        {

            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cd = new SqlCommand("Select * from issue", cn1);
            cn1.Open();
            SqlDataReader dr = cd.ExecuteReader();
            while (dr.Read())
            {

                issued b12 = new issued();
                b12.issueid = Convert.ToInt32(dr[0]);
                b12.bkno = Convert.ToInt32(dr[1]);
                b12.mberid = Convert.ToInt32(dr[2]);
                b12.comments = dr[5].ToString();
                issuelist.Add(b12);


            }
            cn1.Close();
            cn1.Dispose();


        }
        public void addition()
        {
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cd = new SqlCommand("Select * from Users", cn1);
            cn1.Open();
            SqlDataReader dr = cd.ExecuteReader();
            while (dr.Read())
            {

                Userslist ul1 = new Userslist();
                ul1.userid = Convert.ToInt32(dr[0]);
                ul1.userpassword = Convert.ToString(dr[1]);
                ulist.Add(ul1);



            }

            cn1.Close();
            cn1.Dispose();


        }
        public List<Books> bookli()
        {

            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cd = new SqlCommand("Select * from Book", cn1);
            cn1.Open();
            SqlDataReader dr = cd.ExecuteReader();
            while (dr.Read())
            {

                Books b11 = new Books();
                b11.BookId = Convert.ToInt32(dr[0]);
                b11.Bookname = dr[1].ToString();
                b11.Author = dr[2].ToString().Trim();
                b11.Price = Convert.ToDouble(dr[3]);
                b11.Ctegory = dr[4].ToString();
                blist.Add(b11);


            }
            cn1.Close();
            cn1.Dispose();
            return blist;

        }
        public bool validatinguser(int tr, string rt)
        {
            addition();
            Tuple<int, string> tq = Tuple.Create<int, string>(tr, rt);

            Predicate<Tuple<int, string>> p1 = (t) =>
            {

                bool status1 = false;
                foreach (var item in ulist)
                {

                    if (item.userid == t.Item1 && item.userpassword == t.Item2)
                    {
                        status1 = true;
                    }
                }

                return status1;

            };
            return p1.Invoke(tq);



        }
        public bool InsertIssue(issued i1)
        {

            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
            SqlCommand cmdinsert = new SqlCommand("insert into issue(Lib_Issue_Id,Book_No,Member_Id,Issue_Date,Return_Date) values(@book_name,@authors,@pri,@cgory,@gory)", cn1);

            cmdinsert.Parameters.AddWithValue("@book_name", i1.issueid);
            cmdinsert.Parameters.AddWithValue("@authors", i1.bkno);
            cmdinsert.Parameters.AddWithValue("@pri", i1.mberid);
            cmdinsert.Parameters.AddWithValue("@cgory", DateTime.Now);
            cmdinsert.Parameters.AddWithValue("@gory", DateTime.Now.AddDays(15));
            cn1.Open();
            int j = cmdinsert.ExecuteNonQuery();
            bool status = false;
            if (j == 1)
            {
                status = true;
            }
            cn1.Close();
            cn1.Dispose();
            return status;
            return true;
        }
        public bool updatestatus(issued i2)
        {
            issuelists();
            bool sti = false;
            foreach (var item in issuelist)
            {

                if (item.issueid == i2.issueid && item.bkno == i2.bkno && item.mberid == i2.mberid && !(item.comments.Equals("returned")))
                {

                    sti = true;
                }
            }
            Console.WriteLine(sti);

            if (sti)
            {
                SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Bookdata1"].ConnectionString);
                SqlCommand cmdupdate = new SqlCommand("[dbo].[Updatestatus]", cn1);
                cmdupdate.CommandType = System.Data.CommandType.StoredProcedure;
                cmdupdate.Parameters.AddWithValue("@param1", i2.issueid);
                cmdupdate.Parameters.AddWithValue("@param4", i2.bkno);
                cmdupdate.Parameters.AddWithValue("@param6", i2.mberid);

                cmdupdate.Parameters.AddWithValue("@param2", DateTime.Now);


                cmdupdate.Parameters.AddWithValue("@param3", "returned");
                cn1.Open();
                int ik = cmdupdate.ExecuteNonQuery();
                bool status1 = false;
                if (ik == 1) { status1 = true; }

                cn1.Close();
                cn1.Dispose();
                return status1;

            }
            else
            {
                return false;
            }
        }

    }
}
