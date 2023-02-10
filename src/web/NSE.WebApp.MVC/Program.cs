using NSE.WebApp.MVC.Configuration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddIdentityConfiguration();
builder.Services.AddMvcConfiguration();

var app = builder.Build();
app.UseMvcConfiguration();

await app.RunAsync();


//Fazer commit e criar classe startup
