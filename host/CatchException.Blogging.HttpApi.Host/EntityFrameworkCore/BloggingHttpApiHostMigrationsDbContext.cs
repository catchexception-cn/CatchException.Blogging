using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace CatchException.Blogging.EntityFrameworkCore;

public class BloggingHttpApiHostMigrationsDbContext : AbpDbContext<BloggingHttpApiHostMigrationsDbContext>
{
    public BloggingHttpApiHostMigrationsDbContext(DbContextOptions<BloggingHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureBlogging();
    }
}
