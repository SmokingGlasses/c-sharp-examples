using System;
namespace classes
{
    public class Book
    {
        //  Fields
        private int pages;
        private string name;
        private string author;
        private static int bookCount;

        //  Properties
        public static int BookCount
        {
            get { return bookCount; }
        }


        //  Constructor
        public Book()
        {
            this.name = "Unknown";
            this.author = "Unknown";
            this.pages = 0;

            bookCount += 1;
        }

        //  Constructor
        public Book(string name, string author, int pages)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;

            bookCount += 1;
        }

        //  Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Book name : {this.name}, Book author : {this.author}, Pages : {this.pages}");
        }

        public int GetBookCount()
        {
            return bookCount; 
        }

        //  Finalizer
        ~Book()
        {
            //
        }
    }
}