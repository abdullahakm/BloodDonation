using System.ComponentModel;

namespace BloodDonation.Domain.Entities.Enums;

/// <summary>
/// Represents the roles available in the Blood Donation system.
/// </summary>
public enum Role
{
    /// <summary>
    /// A system administrator with full control over the system.
    /// </summary>
    [Description("System Administrator")]
    SystemAdmin,

    /// <summary>
    /// A general system-level user with limited administrative privileges.
    /// </summary>
    [Description("System User")]
    SystemUser,

    /// <summary>
    /// A regular user with access to standard features.
    /// </summary>
    [Description("Simple User")]
    SimpleUser,

    /// <summary>
    /// A client-side user, possibly from a hospital or donation center.
    /// </summary>
    [Description("Client User")]
    ClientUser
}
