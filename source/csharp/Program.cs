using System;
using System.Diagnostics; // For Debug.Assert

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
            // Simple inline test
            Debug.Assert(Greet("World") == "Hello, World!", "Test 'World' Failed!");
            Debug.Assert(Greet("Gemini") == "Hello, Gemini!", "Test 'Gemini' Failed!");

            Console.WriteLine(Greet("World"));
            Console.WriteLine("All inline tests passed!");
        }
    }
}