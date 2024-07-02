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
using webapp.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(i =>
{
  i.AddDefaultPolicy(p =>
  {
    p.AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    p.SetIsOriginAllowed((a) => true);
  });
});
builder.Services.AddSignalR();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(i => i.RegisterServicesFromAssemblies(
  typeof(ChatCommands).Assembly,
  Assembly.GetExecutingAssembly()));
builder.Services.AddDbContext<DB>(i => i.UseSqlite("Data Source=mydb.db"));
builder.Services.AddAutoMapper(typeof(ChatCommands).Assembly);

var app = builder.Build();

var db = app.Services.CreateScope().ServiceProvider.GetService<DB>();
db.Database.Migrate();
app.UseCors();
app.UseRouting();

app.UseEndpoints(i =>
{
  i.MapControllers();
  i.MapHub<ChatHub>("hubs/chat");
});
app.UseSwagger();
app.UseSwaggerUI();
app.Run();