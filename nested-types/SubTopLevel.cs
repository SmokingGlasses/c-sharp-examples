using System;
namespace nestedtypes
{
    public class SubTopLevel : TopLevel
    {
        //  Referring to a nested type from outside the enclosing type
        private TopLevel.PublicNested nested;

        public SubTopLevel()
        {
            //
        }

        //  Applying to protected access modifier to a nested type
        public static void Foo()
        {
            new TopLevel.ProtectedNested();
        }
    }
}
