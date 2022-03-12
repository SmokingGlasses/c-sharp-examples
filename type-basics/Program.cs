using System;

namespace typebasics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunPredefinedTypeExample();
            RunCustomTypeExample();
            RunTypesAndConversionsExample();
        }

        public static void RunPredefinedTypeExample()
        {
            Console.WriteLine("\nPredefined Type Example");

            int number = 7 * 2;
            Console.WriteLine("number : " + number);

            string message = "Hello everyone";
            string upperMessage = message.ToUpper();
            Console.WriteLine("upperMessage : " + upperMessage);

            int year = 2022;
            Console.WriteLine("year : " + year);

            message = message + " " + year.ToString();
            Console.WriteLine("message : " + message);

            bool simpleVariable = false;

            if (simpleVariable)
            {
                Console.WriteLine("This line will nor print");
            }

            int age = 22;
            bool greaterThen = age > 21;

            if (greaterThen)
            {
                Console.WriteLine("This line will print");
            }
        }

        public static void RunCustomTypeExample()
        {
            Console.WriteLine("\nCustom Type Example");

            UnitConvertor feetToInchesConvertor = new UnitConvertor(12);
            UnitConvertor milesToFeetConvertor = new UnitConvertor(5280);

            Console.WriteLine(feetToInchesConvertor.Convert(30));   //  360
            Console.WriteLine(feetToInchesConvertor.Convert(100));  //  1200
            Console.WriteLine(feetToInchesConvertor.Convert(milesToFeetConvertor.Convert(1)));  //  63360
        }

        public static void RunTypesAndConversionsExample()
        {
            Console.WriteLine("\nTypes and Conversions Example");

            int x = 12345;      //  int is a 32-bit integer
            long y = x;         //  Implicit conversion to 64-bit integer
            short z = (short)x; //  Explicit conversion to 16-bit integer

            Console.WriteLine("int x : " + x);
            Console.WriteLine("long y : " + y);
            Console.WriteLine("short z : " + z);
        }
    }

    public class UnitConvertor
    {
        int ratio;  //  Field

        public UnitConvertor(int unitRatio)
        {
            ratio = unitRatio;
        }

        public int Convert(int unit)
        {
            return unit * ratio;
        }
    }
}
