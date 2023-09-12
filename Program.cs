// WebApplication
var builder = WebApplication.CreateBuilder(args);

// middlewares (adiciono)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// middlewares (configuro)
app.MapControllerRoute("default", "/{controller}/{action}/{n?}");

app.Run();





















// http://localhost:1234/[CLASS]/[METHOD]

// http://localhost:1234/[Controller]/[Action]

// class Produto {
// string get() {} 
// }

// http://localhost:1234/Produto/get -> String