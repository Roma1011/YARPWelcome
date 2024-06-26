var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (int x,int y) => $"Hello From Secound Call! {x+y}");

app.Run();
