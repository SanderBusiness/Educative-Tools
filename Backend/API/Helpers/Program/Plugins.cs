using BL.Services.Implementations;
using BL.Services.Interfaces;
using DAL.EF;
using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;

namespace API.Helpers.Program;

public static class Plugins
{
    public static void AddPlugins(this IServiceCollection services)
    {
        services
            .AddSwaggerGen()
            .AddDataAccessLayer()
            .AddBusinessLogic()
            .AddControllers();
    }

    private static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        return services
            .AddScoped<IQuizService, QuizService>();
    }

    private static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
    {
        return services
            .AddDbContext<ApplicationContext>()
            .AddScoped<IQuizRepository, QuizRepository>();
    }

    public static void EnablePlugins(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
            app.UseHsts(); // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        else app
            .UseSwagger()
            .UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
    }
}