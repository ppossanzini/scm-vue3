
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
using Newtonsoft;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(i => i.RegisterServicesFromAssembly(typeof(ChatCommands).Assembly));
builder.Services.AddDbContext<DB>();

var app=builder.Build();
app.UseRouting();
app.UseEndpoints(i => i.MapControllers());
app.UseSwagger();
app.UseSwaggerUI();
app.Run();





