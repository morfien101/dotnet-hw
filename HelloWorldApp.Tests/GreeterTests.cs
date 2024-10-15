namespace HelloWorldApp.Tests;
public class ProgramTest
{
  [Fact]
  public void GreetUser_ReturnsCorrectGreeting()
  {
    // Arrange
    string name = "John";
    string expectedGreeting = "Hello client user, John\n";

    // Act
    string actualGreeting = HelloWorldApp.Greeter.GreetUser(name);

    // Assert
    Assert.Equal(expectedGreeting, actualGreeting);
  }
  [Fact]
  public void GreetUser_ReturnsCorrectGreetingInLanguage()
  {
    // Arrange
    string name = "John";
    string language = "Spanish";
    string expectedGreeting = "Hello client user, John in Spanish\n";
    // Act
    string actualGreeting = HelloWorldApp.Greeter.GreetUser(name, language);
    // Assert
    Assert.Equal(expectedGreeting, actualGreeting);
  }
}