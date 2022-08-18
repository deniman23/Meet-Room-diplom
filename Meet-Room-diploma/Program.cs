var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context => {
    var fileStream = File.ReadAllText(path: "/Users/daniiltolkachev/Desktop/Meet-Room-diplom/Meet-Room-diploma/wwwroot/index.html");

    context.Response.Headers.ContentType = "text/html";
    context.Response.StatusCode = 200;
    context.Response.Headers.Add("My-header", "My-app");

    await context.Response.WriteAsync(fileStream);
});

app.Run();
