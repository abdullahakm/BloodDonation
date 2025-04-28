using BloodDonation.Domain.Entities.Enums;

namespace BloodDonation.Domain.Entities;

/// <summary>
/// Represents a person who can either be a donor, a recipient, or a general user of the system.
/// </summary>
public class Person
{
    /// <summary>
    /// Unique identifier for the person.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// First name of the person.
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// Last name of the person.
    /// </summary>
    public required string LastName { get; set; }

    /// <summary>
    /// Contact number of the person.
    /// </summary>
    public required string Contact { get; set; }

    /// <summary>
    /// CNIC (Computerized National Identity Card) of the person.
    /// </summary>
    public required string Cnic { get; set; }

    /// <summary>
    /// Email address of the person.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// Address of the person.
    /// </summary>
    public required string Address { get; set; }

    /// <summary>
    /// Foreign key referencing the city where the person resides.
    /// </summary>
    public Guid CityId { get; set; }

    /// <summary>
    /// Password hash of the person, used for authentication.
    /// </summary>
    public required byte[] PasswordHash { get; set; }

    /// <summary>
    /// Password salt for securing the password hash.
    /// </summary>
    public required byte[] PasswordSalt { get; set; }

    /// <summary>
    /// Age of the person.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// One-time password (OTP) for authentication or verification purposes.
    /// </summary>
    public required string Otp { get; set; }

    /// <summary>
    /// Role assigned to the person (e.g., donor, recipient, admin).
    /// </summary>
    public Role Role { get; set; }

    /// <summary>
    /// Navigation property to the city where the person resides.
    /// </summary>
    public City? City { get; set; }

    /// <summary>
    /// List of blood tests conducted for the person.
    /// </summary>
    public List<BloodTest>? BloodTests { get; set; }

    /// <summary>
    /// List of blood bank records associated with the person.
    /// </summary>
    public List<BloodRecord>? BloodBanks { get; set; }
}
