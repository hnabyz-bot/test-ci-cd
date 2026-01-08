using Xunit;
using HelloWorld;

public class UnitTest1
{
    [Fact]
    public void TestGreet()
    {
        Assert.Equal("Hello, World!", Program.Greet("World"));
        Assert.Equal("Hello, Gemini!", Program.Greet("Gemini"));
    }
}
