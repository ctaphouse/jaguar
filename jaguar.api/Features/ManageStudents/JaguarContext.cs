using Microsoft.EntityFrameworkCore;

namespace jaguar.api.Features.ManageStudents;

public class JaguarContext : DbContext
{
    public JaguarContext(DbContextOptions<JaguarContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; } = default!;
    public DbSet<Class> Classes { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new ClassConfiguration());
    }
}