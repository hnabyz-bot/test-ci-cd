using System;

namespace HelloWorld
{
    public class Program
    {
        public static string Greet(string name)
        {
            return $"Hello, {name}!";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Greet("World"));
        }
    }
}
