using DAL.EF;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace API.Helpers.Program;

public static class MigrationHelper
{
    public static void EnsureMigrationsComplete(this WebApplication app)
    {
        try
        {
            using var scope = app.Services.CreateScope();
            var loggerFactory = scope.ServiceProvider.GetService<ILoggerFactory>();
            var logger = loggerFactory!.CreateLogger(nameof(MigrationHelper));
            var context = scope.ServiceProvider.GetService<ApplicationContext>();
            if (context!.Database.IsSqlite())
                context.Database.EnsureCreated();
            if (context.Database.IsMySql())
                context.Database.Migrate();
            logger.LogInformation("Migrated database");
        }
        catch
        {
            // Just ignore, I guess we should be happy our db is up-to-date
        }
    }
}