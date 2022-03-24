using System;
namespace interfaces
{
    public class Widget : I1, I2
    {
        public Widget()
        {
            //
        }

        int I1.Foo()
        {
            Console.WriteLine("Widget's implementation of I1.Foo()");
            return 0;
        }

        void I2.Foo()
        {
            Console.WriteLine("Widget's implementation of I2.Foo()");
        }
    }
}
