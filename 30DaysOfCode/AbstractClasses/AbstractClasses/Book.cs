using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AbstractClasses
{
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book()
        {

        }

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        //abstract method will not have a body to its method
        public abstract void display();
    }
}
