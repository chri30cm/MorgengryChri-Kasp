using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgengryNEW
{
    public class Book : Merchandise
    {
        private string title = "";
        private double price = 0;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0) { }

        public Book(string itemId) : this(itemId, "") { }

        public Book() { }

        public override string ToString()
        {
            string result = null;

            result += "ItemId: " + base.ToString() + ", ";
            result += "Title: " + title + ", ";
            result += "Price: " + price;

            return result;
        }
    }
}
