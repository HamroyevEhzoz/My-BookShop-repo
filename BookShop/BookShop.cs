using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class BookShop : IBookShop
    {
        public BookShop(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        List<Book> books = new List<Book>();

        public decimal buyBooks(Book book, int numb)
        {
            decimal num = 0;
            if(book.cost <=Money)
            {
                books.Add(book);
                num = Money/book.cost;

                NumBooks += num;
            }
            return numb;
        }

        public bool hasBook()
        {
            bool result1=false;
            if(NumBooks>0)
            {
                result1 = true;
            }

            return result1;
        }

        public bool hasBook(Book book)
        {
            bool result2 = false;

            return result2;


        }
        public decimal getMoney()
        {
            return Money;
        }

        public decimal sell(Book book, int nums)
        {
            return nums;
        }

        public decimal getCount(Book book)
        {
            return books.Count;
        }

        public string getBookShopName()
        {
            return "";
        }
        public decimal getCount()
        {
            return 1;
        }

        int IBookShop.buyBooks(Book book, int numb)
        {
            throw new NotImplementedException();
        }

        bool IBookShop.hasBook()
        {
            throw new NotImplementedException();
        }

        bool IBookShop.hasBook(Book book)
        {
            throw new NotImplementedException();
        }

        decimal IBookShop.getMoney()
        {
            throw new NotImplementedException();
        }

        decimal IBookShop.sell(Book book, int nums)
        {
            throw new NotImplementedException();
        }

        decimal IBookShop.getCount(Book book)
        {
            throw new NotImplementedException();
        }

        string IBookShop.getBookShopName()
        {
            throw new NotImplementedException();
        }

        decimal IBookShop.getCount()
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }

        public  decimal Money { get; set; }

        public decimal NumBooks { get; set; } = 0;

    }
}
