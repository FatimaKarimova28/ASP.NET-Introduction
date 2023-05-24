var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "User",
    pattern: "{controller=user}/{action=index}"

    );

app.Run();
