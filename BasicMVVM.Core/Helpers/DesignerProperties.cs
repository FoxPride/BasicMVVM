namespace $ext_safeprojectname$.Core.Helpers
{
    /// <summary>   A <see langword="class"/> with helper methods for designer properties. </summary>
    public static class DesignerProperties
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets a value indicating whether is app in design mode. </summary>
        ///
        /// <value> True if this object is design mode, false if not. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsDesignMode { get; set; } = true;
    }
}