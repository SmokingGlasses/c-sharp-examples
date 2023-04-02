using System;

namespace theobjecttype
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunBoxingAndUnboxingExample();
            RunTypeCheckingExample();
        }

        public static void RunBoxingAndUnboxingExample()
        {
            Console.WriteLine("\nBoxing and Unboxing Example");

            int x = 10;
            object obj = x;

            int y = (int)obj;
            // long z = (long)obj;         // InvalidCastException

            Console.WriteLine("x        : " + x);
            Console.WriteLine("obj      : " + obj);
            Console.WriteLine("y        : " + y);

            double w = 3.5;
            object myObj = w;              // 3.5 is inferred to be of type double
            int f = (int)(double)myObj;    // f is now 3

            Console.WriteLine();
            Console.WriteLine("w        : " + w);
            Console.WriteLine("myObj    : " + myObj);
            Console.WriteLine("f        : " + f);

            int i = 2;
            object boxed = i;

            i = 7;

            Console.WriteLine();
            Console.WriteLine("i        : " + i);
            Console.WriteLine("boxed    : " + boxed);

            // Static type checking
            // int e = "4";                // Compile Error

            // Runtime type checking
            object o = "5";
            // int p = (int)o;             // Runtime Error, downcast failed
        }

        public static void RunTypeCheckingExample()
        {
            Console.WriteLine("\nType Checking Example");

            Point point = new Point();

            Console.WriteLine("point.GetType().Name             : " + point.GetType().Name);                                //  Point
            Console.WriteLine("typeof(Point).Name               : " +  typeof(Point).Name);                                 //  Point
            Console.WriteLine("point.GetType() == typeof(Point) : " + (point.GetType() == typeof(Point)));                  //  True
            Console.WriteLine("point.x.GetType().Name           : " + point.x.GetType().Name);                              //  Int32
            Console.WriteLine("point.y.GetType().FullName       : " + point.y.GetType().FullName);                          //  System.Int32
        }

        public class Point
        {
            public int x;
            public int y;
        }
    }
}