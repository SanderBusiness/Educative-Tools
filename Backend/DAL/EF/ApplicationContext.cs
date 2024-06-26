using Domain.Authentication;
using Domain.Quizzes;
using EntityFrameworkCore.Projectables.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DAL.EF;

public class ApplicationContext(ILoggerFactory loggerFactory, IConfiguration configuration) : IdentityDbContext<ApplicationUser>
{
    #region Quiz
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Option> Options { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Participator> Participators { get; set; }
    public DbSet<Response> Responses { get; set; }
    #endregion
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        SetupConnection(ref optionsBuilder);
        optionsBuilder.UseProjectables(o => o.CompatibilityMode(CompatibilityMode.Full));
        optionsBuilder.UseLoggerFactory(loggerFactory);
        base.OnConfiguring(optionsBuilder);
    }

    private void SetupConnection(ref DbContextOptionsBuilder optionsBuilder)
    {
        const string migrationsAssembly = "API";
        var connection = configuration.GetConnectionString("MySQL");
        if (!string.IsNullOrEmpty(connection))
            optionsBuilder.UseMySQL(connection, builder => builder.MigrationsAssembly(migrationsAssembly));
        else 
            optionsBuilder.UseSqlite("Data Source=/DAL/bin/database.db;Version=3;", builder => builder.MigrationsAssembly(migrationsAssembly));
    }
}