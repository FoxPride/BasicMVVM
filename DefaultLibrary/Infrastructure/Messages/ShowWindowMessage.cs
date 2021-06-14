// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShowWindowMessage.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultLibrary.Infrastructure.Messages
{
    using DefaultLibrary.Infrastructure.Enums;
    using DefaultLibrary.ViewModels;

    /// <summary>
    /// Helper class for <see cref="MainWindowViewModel" /> class to show window command.
    /// </summary>
    public class ShowWindowMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowWindowMessage"/> class.
        /// </summary>
        /// <param name="view">
        /// View from views enumeration.
        /// </param>
        public ShowWindowMessage(ViewsEnum view)
        {
            this.View = view;
        }

        /// <summary>
        /// Gets the view.
        /// </summary>
        public ViewsEnum View { get; }
    }
}