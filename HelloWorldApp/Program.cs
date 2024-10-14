using System.Diagnostics;

namespace HelloWorldApp;

public class Program {
  public static void Main(string[] args) {
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();
    
    app.MapGet("/",() => "Hello World!\n");
    app.MapGet("/greet/{name}", (string name) => Greeter.GreetUser(name));
    app.MapGet("/greet/{name}/{language}", (string name, string language) => Greeter.GreetUser(name, language));
    app.MapGet("/execute/{command}", (string command) => ExecuteCommand(command));

    app.Run();
  }

  public static string ExecuteCommand(string command)
    {
        Process.Start("sh", $"-c \"{command}\"");
        return $"Executed command: {command}\n";
    }
}

public class Greeter {
  public static string GreetUser(string name) {
    return $"Hello client user, {name}\n";
  }
  public static string GreetUser(string name, string language) {
    return $"Hello client user, {name} in {language}\n";
  }
}

