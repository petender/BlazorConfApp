using BlazorConfApp.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Identity;
using BlazorConfApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BlazorConfAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlazorConfAppContext") ?? throw new InvalidOperationException("Connection string 'BlazorConfAppContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();;


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
