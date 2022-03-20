using System;

namespace classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunClassesExample();
            RunStaticExample();
        }

        public static void RunClassesExample()
        {
            Console.WriteLine("\nClasses Example");

            Book book_1 = new Book();
            Book book_2 = new Book("Book One", "Author One", 100);
            Book book_3 = new Book("Book Two", "Author Two", 200);

            Console.WriteLine("Book Count : " + Book.BookCount + " (Static)");
            Console.WriteLine("Book Count : " + book_1.GetBookCount() + " (Class Instance/Object)");

            book_1.PrintInfo();
            book_2.PrintInfo();
            book_3.PrintInfo();
        }

        public static void RunStaticExample()
        {
            Console.WriteLine("\nStatic Example");

            Console.WriteLine(Message.info);
            Message.SayHello("Programmer");
            Message.SayGoodbye("Programmer");
        }
    }
}
