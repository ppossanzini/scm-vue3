using Microsoft.EntityFrameworkCore;

namespace handlers.Model;

public class DB : DbContext
{
  public DbSet<Chat> Chats { get; set; }

 
}