using Microsoft.EntityFrameworkCore;
using PersonAPI.Models;

namespace PersonAPI.Data;

public class PersonContext : DbContext
{
    public DbSet<PersonModel> People { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=person.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
