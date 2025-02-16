using System;

namespace generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunGenericsExample();
        }

        public static void Swap<T>(ref T firstVar, ref T secondVar)
        {
            T temp = firstVar;
            firstVar = secondVar;
            secondVar = temp;
        }

        // Default Generic Value
        public static void Zap<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default(T);

                // or
                // array[i] = default;
            }
        }

        public static T Max<T> (T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void Initializer<T> (T[] array) where T : new ()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new T();
            }
        }

        public static void RunGenericsExample()
        {
            Console.WriteLine("Generics Example");

            int stackSize = 10;
            Stack<int> stack = new Stack<int>(stackSize);

            stack.Push(2);
            stack.Push(7);

            int x = stack.Pop();    // 7
            int y = stack.Pop();    // 2

            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);

            // var myStack = new Stack<T>(0);  // Illegal

            int firstVar = 0;
            int secondVar = 1;

            Console.WriteLine();
            Console.WriteLine("firstVar : " + firstVar);
            Console.WriteLine("secondVar : " + secondVar);

            Swap<int>(ref firstVar, ref secondVar);

            Console.WriteLine();
            Console.WriteLine("firstVar : " + firstVar);
            Console.WriteLine("secondVar : " + secondVar);

            int index = 2;
            int myStackSize = 10;
            Stack<string> myStack = new Stack<string>(myStackSize);

            myStack.Push("Hello");
            myStack.Push("my");
            myStack.Push("name");
            myStack.Push("is");
            myStack.Push("David");

            Console.WriteLine();
            Console.WriteLine("index : " + index);
            Console.WriteLine("myStack[index] : " + myStack[index]);

            Console.WriteLine();
            Console.WriteLine(typeof(Stack<>));
            Console.WriteLine(typeof(Stack<int>));
            Console.WriteLine(typeof(Stack<string>));

            int z = Max(5, 10);
            string last = Max("ant", "zoo");
            Console.WriteLine();
            Console.WriteLine("z : " + z);
            Console.WriteLine("last : " + last);
        }
    }
}