using System;

namespace inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunInheritanceExample();
            RunCastingAndReferenceConversionExample();
            RunVirtualFunctionExample();
            RunAbstractExample();
            RunOverloadingExample();
        }

        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }

        public static void Foo(Asset asset)
        {
            Console.WriteLine("Foo(Asset asset)");
        }

        public static void Foo(House house)
        {
            Console.WriteLine("Foo(House house)");
        }

        public static void RunInheritanceExample()
        {
            Console.WriteLine("\nInheritance Example");

            Asset asset = new Asset("Test Asset");
            House house = new House("Test House", 100);
            Stock stock = new Stock("Test Stock", 200);

            Display(asset);
            Display(house);
            Display(stock);
        }

        public static void RunCastingAndReferenceConversionExample()
        {
            Console.WriteLine("\nCasting and Reference Conversion Example");

            //  Upcasting
            Stock stockUp = new Stock();
            Asset assetUp = stockUp;

            Console.WriteLine("assetUp == stockUp : " + (assetUp == stockUp));          //  True
            Console.WriteLine("assetUp.Name : " + assetUp.Name);                        //  OK 
            //  Console.WriteLine("assetUp.SharesOwned : " + assetUp.SharesOwned);      //  Compile-time error

            //  Downcasting
            Stock stockDown = new Stock();
            Asset assetDown = stockDown;    //  Upcast
            Stock cast = (Stock)assetDown;  //  Downcast

            Console.WriteLine("cast.SharesOwned : " + cast.SharesOwned);        //  OK
            Console.WriteLine("cast == assetDown : " + (cast == assetDown));    //  True
            Console.WriteLine("cast == stockDown : " + (cast == stockDown));    //  True
        }

        public static void RunVirtualFunctionExample()
        {
            Console.WriteLine("\nVirtual Function Example");

            House mansion = new House("Mansion", 250000);
            Asset asset = mansion;

            Console.WriteLine("asset.Liability : " + asset.Liability);
            Console.WriteLine("mansion.Liability : " + mansion.Liability);
        }

        public static void RunAbstractExample()
        {
            Console.WriteLine("\nAbstract Example");

            Shop shop = new Shop(10, 1500);
            Console.WriteLine("shop.NetValue : " + shop.NetValue);
            Console.WriteLine("shop.GetNetValue() : " + shop.GetNetValue());
        }

        public static void RunOverloadingExample()
        {
            Console.WriteLine("\nOverloading Example");

            House house = new House();
            Asset asset = new House();

            Foo(house);                 //  Calls Foo(House house)
            Foo(asset);                 //  Calls Foo(Asset asset)
            //  Foo((dynamic)asset);    //  Calls Foo(House house)  
        }
    }
}
