using BasicMVVM.Core.Infrastructure.Enums;
using BasicMVVM.Core.ViewModels;

namespace BasicMVVM.Core.Infrastructure.Messages
{
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
            View = view;
        }

        /// <summary>
        /// Gets the view.
        /// </summary>
        public ViewsEnum View { get; }
    }
}