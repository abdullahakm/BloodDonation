using System.ComponentModel;

namespace BloodDonation.Domain.Entities.Enums;

/// <summary>
/// Represents the blood groups available in the blood donation system.
/// </summary>
public enum BloodGroup
{
    /// <summary>
    /// Blood group A positive.
    /// </summary>
    [Description("A+")]
    A_Positive,

    /// <summary>
    /// Blood group A negative.
    /// </summary>
    [Description("A−")]
    A_Negative,

    /// <summary>
    /// Blood group B positive.
    /// </summary>
    [Description("B+")]
    B_Positive,

    /// <summary>
    /// Blood group B negative.
    /// </summary>
    [Description("B−")]
    B_Negative,

    /// <summary>
    /// Blood group AB positive.
    /// </summary>
    [Description("AB+")]
    AB_Positive,

    /// <summary>
    /// Blood group AB negative.
    /// </summary>
    [Description("AB−")]
    AB_Negative,

    /// <summary>
    /// Blood group O positive.
    /// </summary>
    [Description("O+")]
    O_Positive,

    /// <summary>
    /// Blood group O negative.
    /// </summary>
    [Description("O−")]
    O_Negative
}
