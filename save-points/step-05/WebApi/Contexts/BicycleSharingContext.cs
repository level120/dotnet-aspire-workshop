using Microsoft.EntityFrameworkCore;

public class BicycleSharingContext(DbContextOptions<BicycleSharingContext> dbContextOptions)
        : DbContext(dbContextOptions)
{
    public DbSet<RentalOfficeModel> RentalOffices => Set<RentalOfficeModel>();

    public DbSet<BicycleModel> Bicycles => Set<BicycleModel>();

    public async Task InitializeDatabaseAsync()
    {
        await Database.EnsureCreatedAsync().ConfigureAwait(false);
    }
}