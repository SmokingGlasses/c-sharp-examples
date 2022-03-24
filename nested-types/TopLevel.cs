using System;
namespace nestedtypes
{
    public class TopLevel
    {
        public static int topLevelVariable;     //  Static variable
        public enum Color { Red, Blue, Green};  //  Nested enum

        public TopLevel()
        {
            //
        }

        //  Public nested class
        public class PublicNested
        {
            //
        }

        //  Private nested class
        private class PrivateNested {
            //  Accessing a member of a type from nested type
            static void Foo()
            {
                Console.WriteLine("topLevelVariable : " + TopLevel.topLevelVariable);
            }
        }

        //  Protected nested class
        protected class ProtectedNested
        {
            //
        }
    }
}
