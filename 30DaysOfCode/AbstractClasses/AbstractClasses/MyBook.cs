using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class MyBook : Book
    {
        //string title;
        //string author;
        int price;

        public MyBook()
        {

        }
        public MyBook(string title, string author, int price): base()
        {
            this.title = title;
            this.author = author;
            this.price = price;

        }

        public override void display()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author);
            Console.WriteLine("Price: " + this.price);
        }
        


    }
}
