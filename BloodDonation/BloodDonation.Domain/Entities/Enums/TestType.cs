using System.ComponentModel;

namespace BloodDonation.Domain.Entities.Enums
{
    /// <summary>
    /// Represents the types of medical tests performed during blood screening.
    /// </summary>
    public enum TestType
    {
        /// <summary>
        /// Test to count different types of blood cells (e.g., RBCs, WBCs, Platelets).
        /// </summary>
        [Description("Blood Cell Count")]
        CountBloodCell,

        /// <summary>
        /// Hepatitis B surface antigen test.
        /// </summary>
        [Description("HBsAg")]
        HBsAg,

        /// <summary>
        /// Hepatitis C antibody test.
        /// </summary>
        [Description("Anti-HCV")]
        AntiHCV,

        /// <summary>
        /// Human Immunodeficiency Virus (HIV) test.
        /// </summary>
        [Description("HIV")]
        HIV,

        /// <summary>
        /// Venereal Disease Research Laboratory (VDRL) test for syphilis.
        /// </summary>
        [Description("VDRL")]
        VDRL
    }
}
