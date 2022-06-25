using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms._30DaysOfCode.Day_13
{
    public class MyBook : Book
    {
        private int price;

        public MyBook(string title, string author, int price)
            : base(title, author)
        {
            this.price = price;
        }

        public override void Display()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Price: " + price.ToString());
        }
    }
}
