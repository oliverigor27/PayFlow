using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace PayFlow.User.Infra.Database;

public class AppDbContext(DbContextOptions<AppDbContext> context) : DbContext(context)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
