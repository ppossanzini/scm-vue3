using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace handlers.Model;

public class DB(DbContextOptions<DB> options) : DbContext(options)
{
  public DbSet<Chat> Chats { get; set; }
  
}

public class SQLLiteContextFactory : IDesignTimeDbContextFactory<DB>
{
  public DB CreateDbContext(string[] args)
  {
    var optionsBuilder = new DbContextOptionsBuilder<DB>();
    optionsBuilder.UseSqlite();
    return new DB(optionsBuilder.Options);
  }
}