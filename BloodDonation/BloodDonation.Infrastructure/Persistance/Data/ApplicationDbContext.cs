using BloodDonation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BloodDonation.Infrastructure.Persistance.Data;

/// <summary>
/// Represents the database context for the Blood Donation application, providing access to all entities in the database.
/// </summary>
/// <remarks>
/// This class inherits from <see cref="DbContext"/> and is responsible for configuring the database connection,
/// defining entity relationships, and managing database operations for the Blood Donation domain entities.
/// </remarks>
/// <param name="options">The options to be used by the DbContext for configuration.</param>
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    /// <summary>
    /// Gets or sets the DbSet for <see cref="Hospital"/> entities, representing hospitals that participate in blood donation.
    /// </summary>
    public DbSet<Hospital> Hospitals { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for <see cref="City"/> entities, representing cities where hospitals and donors are located.
    /// </summary>
    public DbSet<City> Cities { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for <see cref="BloodTest"/> entities, representing blood test results for donations.
    /// </summary>
    public DbSet<BloodTest> BloodTests { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for <see cref="BloodRecord"/> entities, representing records of blood donations and inventory.
    /// </summary>
    public DbSet<BloodRecord> BloodRecords { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for <see cref="Person"/> entities, representing individuals involved in the blood donation process
    /// (donors, staff, or other personnel).
    /// </summary>
    public DbSet<Person> Persons { get; set; }
}