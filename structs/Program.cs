using System;

namespace structs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunStructsExample();
        }

        public static void Foo(Point point)
        {
            Console.WriteLine("point x : " + point.x);
            Console.WriteLine("point y : " + point.y);
        }

        public static void RunStructsExample()
        {
            Console.WriteLine("\nStructs Example");

            Point p1 = new Point();
            Point p2 = new Point(1, 1);
            Point p3 = default;

            Foo(new Point());   // Equivalent to Foo (default);
            Foo(default);       // Equivalent to Foo (new Point());
        }

        public struct Point
        {
            public int x;
            public int y;

            public Point (int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public struct Position
        {
            // public int x = 1;                           // Illegal: field initializer
            public int y;

            // public Point() {}                           // Illegal: parameterless constructor
            // public Point(int x) { this.x = x; }         // Illegal: must assign field y
        }

        public readonly struct Vector
        {
            // x and y must be readonly
            public readonly int x;
            public readonly int y;
        }
    }
}