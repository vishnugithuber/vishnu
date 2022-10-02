using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{  
    public class Books
        {
            private int _bookId;
            public int BookId
            {
                get { return _bookId; }
                set
                {
                    if (value > 100)
                    {
                        _bookId = value;
                    }
                    else
                    {
                        throw new Exception("It is not recommended");
                    }
                }
            }
            private string _bookname;
            public string Bookname
            {
                get { return _bookname; }
                set
                {
                    if (value.Length > 40)
                    {
                        throw new Exception("It is not valid");
                    }
                    else
                    {
                        _bookname = value;
                    }
                }

            }
            private string _author;
            public string Author
            {
                get { return _author; }
                set
                {
                    if (String.IsNullOrEmpty(value) || value.Length > 30)
                    {
                        throw new Exception("It is not valid");
                    }
                    else
                    {
                        _author = value;
                    }
                }
            }
            private double price;
            public double Price
            {
                get { return price; }
                set
                {
                    if (value < 3000 && value > 0)
                    {
                        price = value;
                    }
                    else if (price < 0)
                    {
                        throw new Exception("It cannnot low");
                    }

                }
            }

            private string ctegory;
            public string Ctegory
            {
                get { return ctegory; }
                set
                {
                    if (value.Length <= 10)
                    {
                        ctegory = value;
                    }
                    else
                    {
                        throw new Exception("It is not valid");
                    }
                }
            }
        }
        public class Userslist
        {
            public int userid
            {
                get;
                set;
            }
            public string userpassword
            {
                get;
                set;
            }
        }
        public class issued
        {
            public int issueid
            {
                get;
                set;
            }
            public int bkno
            {
                get;
                set;
            }
            public int mberid
            {
                get;
                set;
            }
            public DateTime dte
            {
                get;
                set;
            }
            public DateTime rte
            {
                get;
                set;
            }
            public string comments
            {
                get;
                set;
            }
        }
    }

