//
// namespace webapp
// {
//   public static class Program
//   {
//     public static void main(string[] args)
//     {
//       var builder = WebApplication.CreateBuilder(args);
//
//     }
//   }
//   
// }

using System.Reflection;
using System.Security.Principal;
using handlers.Commands;
using handlers.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(i => i.RegisterServicesFromAssembly(typeof(ChatCommands).Assembly));
builder.Services.AddDbContext<DB>(i => i.UseSqlite("Data Source=mydb.db"));
builder.Services.AddAutoMapper(typeof(ChatCommands).Assembly);

var app = builder.Build();

var db = app.Services.CreateScope().ServiceProvider.GetService<DB>();
db.Database.Migrate();

app.UseRouting();
app.UseEndpoints(i => i.MapControllers());
app.UseSwagger();
app.UseSwaggerUI();
app.Run();