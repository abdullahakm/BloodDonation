using BloodDonation.Domain.Entities.Enums;

namespace BloodDonation.Domain.Entities;

/// <summary>
/// Represents a hospital, including its name, address, and related city and province.
/// </summary>
public class Hospital
{
    /// <summary>
    /// Unique identifier for the hospital.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Province where the hospital is located.
    /// </summary>
    public Province Province { get; set; }

    /// <summary>
    /// Foreign key referencing the city where the hospital is located.
    /// </summary>
    public Guid CityId { get; set; }

    /// <summary>
    /// Name of the hospital.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Address of the hospital.
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// Navigation property to the city where the hospital is located.
    /// </summary>
    public City? City { get; set; }
}
