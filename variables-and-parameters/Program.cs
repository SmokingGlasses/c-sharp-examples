using System;

namespace variablesandparameters
{
    class MainClass
    {
        static string oldValue = "Old Value";
        static ref string GetOldValue() => ref oldValue;

        public static void Main(string[] args)
        {

            RunParametersExample();
            RunRefExample();
        }

        public static void RunParametersExample()
        {
            Console.WriteLine("\nParameters Example");

            int x = 7;
            Foo(x);
            Console.WriteLine("x outside Foo(int p) : " + x);
            Console.WriteLine("");

            Foo(ref x);
            Console.WriteLine("x outside Foo(ref int p) : " + x);
            Console.WriteLine("");


            string firstName = "David";
            string secondName = "Bagrat";

            Console.WriteLine("firstName before Swap(ref a, ref b) : " + firstName);
            Console.WriteLine("secondName before Swap(ref a, ref b) : " + secondName);
            Console.WriteLine("");

            Swap(ref firstName, ref secondName);

            Console.WriteLine("firstName after Swap(ref a, ref b) : " + firstName);
            Console.WriteLine("secondName after Swap(ref a, ref b) : " + secondName);
            Console.WriteLine("");

            string fullName = "Mary Elizabeth Smith";
            string a, b;

            Split(fullName, out a, out b);

            Console.WriteLine("First Name : " + a);
            Console.WriteLine("Last Name : " + b);
            Console.WriteLine("");

            int p = 2;

            Boo(p);
            Boo(in p);
        }

        public static void RunRefExample()
        {
            Console.WriteLine("\nRef Example");

            //  Ref Locals
            int[] numbers = { 0, 1, 2, 3, 4, 5 };
            ref int numRef = ref numbers[2];

            numRef *= 10;
            Console.WriteLine("numRef : " + numRef);
            Console.WriteLine("numbers[2] : " + numbers[2]);


            //  Ref Returns
            ref string oldValueRef = ref GetOldValue();
            oldValueRef = "Very Old Value";
            Console.WriteLine(oldValueRef);

            
        }

        //  Passing arguments by value
        public static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine("p inside Foo(int p) : " + p);
        }

        //  The ref modifier
        public static void Foo(ref int p)
        {
            p = p + 1;
            Console.WriteLine("p inside Foo(ref int p) : " + p);
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        //  The out modifier
        public static void Split(string name, out string firstName, out string lastName)
        {
            int i = name.LastIndexOf(' ');

            firstName = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        //  The in modifier
        public static void Boo(int p)
        {
            p++;
            Console.WriteLine("p inside Boo(int p) : " + p);
        }

        public static void Boo(in int p)
        {
            //p++;  // error
            Console.WriteLine("p inside Boo(in int p) : " + p);
        }
    }
}
