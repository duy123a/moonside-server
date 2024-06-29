using Microsoft.EntityFrameworkCore;

namespace PostService.Data;

public static class DbInitializer
{
    public static void InitDb(this WebApplication app)
    {
        // As we using this one before the method app.Run and want to access its service
        // We need to create an own scope for it .~.
        using var scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<ApplicationDbContext>());
    }

    private static void SeedData(ApplicationDbContext? context)
    {
        if (context == null) return;
        context.Database.Migrate();
        // If we already have a data, no need to seed
        if (context.Posts.Any()) return;

        // TODO: Seed the data
    }
}
