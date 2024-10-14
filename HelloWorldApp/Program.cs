var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


string greetUser (string name) {
  return $"Hello client user, {name}\n";
}

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet/{name}", (string name) => greetUser(name));
app.Run();
