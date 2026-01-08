using Xunit;

namespace HelloWorld.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_WithName_ReturnsGreeting()
    {
        // Arrange
        string name = "World";
        
        // Act
        string result = Greeter.Greet(name);
        
        // Assert
        Assert.Equal("Hello, World!", result);
    }

    [Fact]
    public void Greet_WithDifferentName_ReturnsCorrectGreeting()
    {
        // Arrange
        string name = "GitHub";
        
        // Act
        string result = Greeter.Greet(name);
        
        // Assert
        Assert.Equal("Hello, GitHub!", result);
    }
}
