using BloodDonation.Domain.Entities.Enums;

namespace BloodDonation.Domain.Entities
{
    /// <summary>
    /// Represents a city, including its name, province, and related people and hospitals.
    /// </summary>
    public class City
    {
        /// <summary>
        /// Unique identifier for the city.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the city.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Province to which the city belongs.
        /// </summary>
        public Province Province { get; set; }

        /// <summary>
        /// Navigation property for the list of people who reside in the city.
        /// </summary>
        public List<Person>? Persons { get; set; }

        /// <summary>
        /// Navigation property for the list of hospitals located in the city.
        /// </summary>
        public List<Hospital>? Hospitals { get; set; }
    }
}
