using System;

namespace generics
{
    public class GenericClass<T, U> where T : SomeClass, I1
                                    where U : new ()
    {
        public GenericClass()
        {
            //
        }
    }
}