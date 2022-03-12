using System;

namespace numerictypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunNumbericLiteralsExample();
            RunNumbericConversionsExample();
            RunOverflowExample();
            RunSpecialFloatAndDoubleValuesExample();
        }

        public static void RunNumbericLiteralsExample()
        {
            Console.WriteLine("\nNumberic Literals Example");

            //  decimal
            int x = 127;
            Console.WriteLine("x : " + x + " (" + x.GetType() + ")");

            //  hex (0x)
            long y = 0x7f;
            Console.WriteLine("y : " + y + " (" + y.GetType() + ")");

            //  decimal (more readable)
            int million = 1_000_000;
            Console.WriteLine("million : " + million + " (" + million.GetType() + ")");

            //  binary (0b)
            var b = 0b1010_1011_1100_1101_1110_111;
            Console.WriteLine("b: " + b + " (" + b.GetType() + ")");

            //  decimal and/or exponential notation
            double d = 1.5;
            Console.WriteLine("d : " + d + " (" + d.GetType() + ")");

            double billion = 1E09;
            Console.WriteLine("billion : " + billion + " (" + billion.GetType() + ")");
        }

        public static void RunNumbericConversionsExample()
        {
            Console.WriteLine("\nNumberic Conversions Example");

            int x = 12345;      //  int is a 32-bit integer
            long y = x;         //  Implicit conversion to 64-bit integer
            short z = (short)x; //  Explicit conversion to 16-bit integer

            Console.WriteLine("int x : " + x);
            Console.WriteLine("long y : " + y);
            Console.WriteLine("short z : " + z);

            int i1 = 1;
            float f = i1;
            int i2 = (int)f;
            Console.WriteLine("\nint i1 : " + i2);
            Console.WriteLine("float f : " + f);
            Console.WriteLine("int i2 : " + i2);

            int i3 = 100000001;
            float f1 = i3;
            int i4 = (int)f1;
            Console.WriteLine("\nint i3 : " + i3);
            Console.WriteLine("float f1 : " + f1);
            Console.WriteLine("int i4 : " + i4);
        }

        public static void RunOverflowExample()
        {
            Console.WriteLine("\nOverflow Example");

            int number = int.MinValue;
            Console.WriteLine("number : " + number + " (int.MinValue)");

            number--;
            Console.WriteLine("number = number - 1:");

            Console.WriteLine("number == int.MaxValue : " + (number == int.MaxValue));
        }

        public static void RunSpecialFloatAndDoubleValuesExample()
        {
            Console.WriteLine("\nSpecial Float and Double Values Example");

            Console.WriteLine("1.0 / 0.0 : " + 1.0 / 0.0);
            Console.WriteLine("-1.0 / 0.0 : " + -1.0 / 0.0);
            Console.WriteLine("1.0 / -0.0 : " + 1.0 / -0.0);
            Console.WriteLine("-1.0 / -0.0 : " + -1.0 / -0.0);

            Console.WriteLine("\n0.0 / 0.0 : " + 0.0 / 0.0);
            Console.WriteLine("(1.0 / 0.0) - (1.0 / 0.0) : " + ((1.0 / 0.0) - (1.0 / 0.0)));

            Console.WriteLine("\n0.0 / 0.0 == double.NaN : " + (0.0 / 0.0 == double.NaN));
            Console.WriteLine("double.IsNaN(0.0 / 0.0) : " + double.IsNaN(0.0 / 0.0));
            Console.WriteLine("object.Equals(0.0 / 0.0, double.NaN) : " + object.Equals(0.0 / 0.0, double.NaN));
        }
    }
}
