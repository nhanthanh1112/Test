
using Blazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ILogin,LoginServices>();
builder.Services.AddHttpClient<ILogin, LoginServices>();
builder.Services.AddScoped<IGetValue, GetValueServices>();
builder.Services.AddHttpClient<IGetValue, GetValueServices>();
builder.Services.AddServerSideBlazor();


var app = builder.Build();
app.Services.GetServices(typeof(LoginServices));
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
