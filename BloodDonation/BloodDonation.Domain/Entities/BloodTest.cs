using BloodDonation.Domain.Entities.Enums;

namespace BloodDonation.Domain.Entities
{
    /// <summary>
    /// Represents a medical test conducted on a person's blood to determine eligibility for donation.
    /// </summary>
    public class BloodTest
    {
        /// <summary>
        /// Unique identifier for the blood test record.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the person who took the blood test.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Type of medical test conducted.
        /// </summary>
        public TestType TestType { get; set; }

        /// <summary>
        /// Result of the test, indicating whether the result is Positive or Negative.
        /// </summary>
        public TestOutcome TestOutcome { get; set; }

        /// <summary>
        /// Indicates whether the person is eligible to donate blood based on the test result.
        /// </summary>
        public bool Eligible { get; set; }

        /// <summary>
        /// Date on which the test was conducted.
        /// </summary>
        public DateTime TestDate { get; set; }

        /// <summary>
        /// Navigation property to the person associated with this blood test.
        /// </summary>
        public Person? Person { get; set; }
    }
}
