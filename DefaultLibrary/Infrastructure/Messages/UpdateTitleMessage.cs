// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateTitleMessage.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultLibrary.Infrastructure.Messages
{
    using DefaultLibrary.ViewModels;

    /// <summary>
    /// Helper class for <see cref="SecondWindowViewModel" /> class to change title.
    /// </summary>
    public class UpdateTitleMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTitleMessage"/> class.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        public UpdateTitleMessage(string title)
        {
            this.Title = title;
        }

        /// <summary>
        /// Gets the title.
        /// </summary>
        public string Title { get; }
    }
}