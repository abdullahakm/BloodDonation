using BloodDonation.Domain.Entities.Enums;

namespace BloodDonation.Domain.Entities
{
    /// <summary>
    /// Represents a blood record that tracks either a blood donation or a blood request made by a person.
    /// </summary>
    public class BloodRecord
    {
        /// <summary>
        /// Unique identifier for the blood record.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Foreign key referencing the person who donated or requested the blood.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Blood group involved in the donation or request.
        /// </summary>
        public BloodGroup BloodGroup { get; set; }

        /// <summary>
        /// Amount of blood in milliliters.
        /// </summary>
        public int AmountInMilliliters { get; set; }

        /// <summary>
        /// Specifies whether the action is a blood donation or a request.
        /// </summary>
        public BloodActionType ActionType { get; set; }

        /// <summary>
        /// Expiry date of the stored blood unit, if applicable.
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Date when the blood was requested, if applicable.
        /// </summary>
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// Date when the blood was donated, if applicable.
        /// </summary>
        public DateTime DonationDate { get; set; }

        /// <summary>
        /// Navigation property to the person associated with this blood record.
        /// </summary>
        public Person? Person { get; set; }
    }
}
