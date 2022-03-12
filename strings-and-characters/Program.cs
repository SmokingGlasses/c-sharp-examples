using System;

namespace stringsandcharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RunCharacterTypeExample();
            RunStringTypeExample();
        }

        public static void RunCharacterTypeExample()
        {
            Console.WriteLine("\nCharacter Type Example");

            char c = 'A';   //  Simple character
            char newLine = '\n';    //  escape sequence character
            char backSlash = '\\';  //  escape sequence character

            Console.WriteLine("c : " + c);
            Console.WriteLine("backSlash : " + backSlash);
            Console.WriteLine("newLine : " + newLine);


            char unicodeCopyRightSymbol = '\u00A9';
            char unicodeOmegaSymbol = '\u03A9';
            char unicodeNewLine = '\u000A';

            Console.WriteLine("unicodeCopyRightSymbol : " + unicodeCopyRightSymbol);
            Console.WriteLine("unicodeOmegaSymbol : " + unicodeOmegaSymbol);
            Console.WriteLine("unicodeNewLine : " + unicodeNewLine);

        }

        public static void RunStringTypeExample()
        {
            Console.WriteLine("\nString Type Example");

            string a = "test";
            string b = "test";
            Console.WriteLine(a == b);  //  True
            Console.WriteLine("");

            string c = "\\\\server\\fileshare\\helloworld.cs";
            string d = @"\\server\fileshare\helloworld.cs";

            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("");

            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line
Second Line";

            Console.WriteLine(escaped);
            Console.WriteLine(verbatim);
            Console.WriteLine("");

            //  True if your text editor uses CR-LF line seperators
            Console.WriteLine(escaped == verbatim);
            Console.WriteLine("");

            string xml = @"<customer id=""123""></customer>";
            Console.WriteLine(xml);
            Console.WriteLine("");

            int e = 4;
            Console.WriteLine($"A square has {e} sides");

            string f = $"255 in hex is {byte.MaxValue:X2}";
            Console.WriteLine(f);

            bool g = true;
            Console.WriteLine($"The answer in binary is {(g ? 1 : 0)}");
            Console.WriteLine("");

            int h = 2;
            string i = $@"this spans
{h} lines";

            Console.WriteLine(i);
        }
    }
}
