using Microsoft.EntityFrameworkCore;
using Connor.Persistance.Models;

namespace Connor.Persistance;

public class PersistanceContext(DbContextOptions<PersistanceContext> options) : DbContext(options)
{
    public DbSet<Models.Connor> Connors { get; set; }
    public DbSet<Prompt> Prompts { get; set; }
    public DbSet<Receiver> Receivers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersistanceContext).Assembly);
};