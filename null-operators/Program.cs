using System;

namespace nulloperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunNullOperatorsExample();
        }

        public static void RunNullOperatorsExample()
        {
            Console.WriteLine("\nNull Operators Example");

            //  Null-Coalescing Operator
            //  (if the operand to the left is non-null, give it to me, otherwise give me another value)

            string s1 = null;
            string s2 = s1 ?? "nothing";
            Console.WriteLine("s2 : " + s2);
            Console.WriteLine("");

            //  Null-Coalescing Assignment Operator (C# 8)
            //  (if the operand to the left is null, assign the right operand to the left operand)

            //  string s3 = null;
            //  s3 ??= "some value";
            //  Console.WriteLine("s3 : " + s3);
            //  Console.WriteLine("");

            //  Null-Conditional Operator
            string numberString = "Some Number";
            string s4 = numberString?.ToString();   //  No Error, s4 evaluates to null
            Console.WriteLine("s4 : " + s4);
            Console.WriteLine("");

            SomeClass someValue = new SomeClass();
            someValue?.SomeMethod();
            Console.WriteLine("");
        }

        public class SomeClass
        {
            public void SomeMethod()
            {
                Console.WriteLine("Some Method");
            }
        }
    }
}
