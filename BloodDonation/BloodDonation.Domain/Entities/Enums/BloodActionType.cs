namespace BloodDonation.Domain.Entities.Enums
{
    /// <summary>
    /// Specifies the type of blood-related action performed by a person.
    /// </summary>
    public enum BloodActionType
    {
        /// <summary>
        /// Indicates that the person has donated blood.
        /// </summary>
        Donation,

        /// <summary>
        /// Indicates that the person has requested blood.
        /// </summary>
        Request
    }
}
