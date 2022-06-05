using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {
        public Book(string Name, decimal cost)
        {
            this.Name = Name;
            this.cost = cost;

        }

        public string Name { get; set; }

        public decimal cost { get; set; }






    }
}
