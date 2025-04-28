using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BloodDonation.Infrastructure.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BloodDonationApi.DbMigrator
{
    /// <summary>
    /// The main program class for database migration operations.
    /// </summary>
    /// <remarks>
    /// This console application handles database migrations for the Blood Donation system,
    /// ensuring the database schema is up-to-date with the application's entity models.
    /// </remarks>
    public class Program
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        /// <param name="args">Command-line arguments passed to the application.</param>
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder().Build();
            MigrateDatabase(host);
            Console.WriteLine("Database migration completed successfully.");
        }

        /// <summary>
        /// Creates and configures the host builder for the migration application.
        /// </summary>
        /// <returns>An <see cref="IHostBuilder"/> configured for database migration.</returns>
        /// <remarks>
        /// Configures the application to:
        /// - Use appsettings.json for configuration
        /// - Set up the ApplicationDbContext with SQL Server
        /// - Configure console logging
        /// </remarks>
        public static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(AppContext.BaseDirectory);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    var configuration = hostContext.Configuration;

                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

                    services.AddLogging(logging =>
                    {
                        logging.ClearProviders();
                        logging.AddConsole();
                    });
                });

        /// <summary>
        /// Executes the database migration process.
        /// </summary>
        /// <param name="host">The host containing the configured services.</param>
        /// <remarks>
        /// This method:
        /// - Creates a service scope
        /// - Retrieves the ApplicationDbContext
        /// - Applies any pending migrations
        /// - Handles and logs any migration errors
        /// </remarks>
        private static void MigrateDatabase(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var db = services.GetRequiredService<ApplicationDbContext>();
                db.Database.Migrate();
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred while migrating the database.");
            }
        }
    }
}