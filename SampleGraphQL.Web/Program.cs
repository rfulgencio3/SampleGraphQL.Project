using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using SampleGraphQL.Web.Models;
using SampleGraphQL.Web.Queries;
using SampleGraphQL.Web.Services;
using SampleGraphQL.Web.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddGraphQLServer().AddQueryType<CarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UsePlayground(new PlaygroundOptions 
    { 
        QueryPath = "/api",
        Path = "/playground"
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.MapGet("/", () => "Hello World");

app.Run();
