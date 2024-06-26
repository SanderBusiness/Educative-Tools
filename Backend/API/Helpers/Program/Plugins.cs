using DAL.EF;

namespace API.Helpers.Program;

public static class Plugins
{
    public static IServiceCollection AddPlugins(this IServiceCollection services)
    {
        services
            .AddSwaggerGen()
            .AddDataAccessLayer()
            .AddBusinessLogic()
            .AddControllers();
        return services;
    }

    private static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        return services;
    }

    private static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
    {
        return services
            .AddDbContext<ApplicationContext>();
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