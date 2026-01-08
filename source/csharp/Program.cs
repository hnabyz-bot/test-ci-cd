namespace HelloWorld;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Greeter.Greet("World"));
    }
}

public class Greeter
{
    public static string Greet(string name)
    {
        return $"Hello, {name}!";
    }
}
