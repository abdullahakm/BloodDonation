using BloodDonation.Domain.Entities.Enums;

namespace BloodDonation.Domain.Entities
{
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
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Last name of the person.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Contact number of the person.
        /// </summary>
        public string Contact { get; set; } = string.Empty;

        /// <summary>
        /// CNIC (Computerized National Identity Card) of the person.
        /// </summary>
        public string Cnic { get; set; } = string.Empty;

        /// <summary>
        /// Email address of the person.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Address of the person.
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Foreign key referencing the city where the person resides.
        /// </summary>
        public Guid CityId { get; set; }

        /// <summary>
        /// Password hash of the person, used for authentication.
        /// </summary>
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Password salt for securing the password hash.
        /// </summary>
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Age of the person.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// One-time password (OTP) for authentication or verification purposes.
        /// </summary>
        public string Otp { get; set; } = string.Empty;

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
}
