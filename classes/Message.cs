using System;
namespace classes
{
    public static class Message
    {
        public static string info = "I am a Static Message Class";

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}, nice to meet you!");
        }

        public static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}, see you soon!");
        }
    }
}
