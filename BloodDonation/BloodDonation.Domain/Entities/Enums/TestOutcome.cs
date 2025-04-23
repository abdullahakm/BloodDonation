namespace BloodDonation.Domain.Entities.Enums
{
    /// <summary>
    /// Represents the outcome of a blood test.
    /// </summary>
    public enum TestOutcome
    {
        /// <summary>
        /// The test result was negative (no disease or issue found).
        /// </summary>
        Negative = 0,

        /// <summary>
        /// The test result was positive (disease or issue found).
        /// </summary>
        Positive = 1
    }
}
