﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CatchException.Blogging.EntityFrameworkCore;

public class BloggingHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BloggingHttpApiHostMigrationsDbContext>
{
    public BloggingHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BloggingHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Blogging"));

        return new BloggingHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
