using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public interface IBookShop
    {

        public int buyBooks(Book book,int numb);

        public bool hasBook();

        public bool hasBook(Book book);

        public decimal getMoney();

        public decimal sell(Book book, int nums);

        public decimal getCount(Book book);

        public string getBookShopName();
        public decimal getCount();
    }
}
