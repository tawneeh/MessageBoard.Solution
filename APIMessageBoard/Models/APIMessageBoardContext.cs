using Microsoft.EntityFrameworkCore;

namespace APIMessageBoard.Models
{
  public class APIMessageBoardContext : DbContext
  {
    public APIMessageBoardContext(DbContextOptions<APIMessageBoardContext> options)
        : base(options)
    {
    }

    public DbSet<Group> Groups { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Group>()
          .HasData(
              new Group {  },
              new Group {  }
          );
    }
  }
}