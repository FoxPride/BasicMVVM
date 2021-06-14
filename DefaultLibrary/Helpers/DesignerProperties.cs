// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignerProperties.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultLibrary.Helpers
{
    /// <summary>
    /// A <see langword="class"/> with helper methods for designer properties.
    /// </summary>
    public static class DesignerProperties
    {
        /// <summary>
        /// Gets or sets a value indicating whether is app in design mode.
        /// </summary>
        public static bool IsDesignMode { get; set; } = true;
    }
}