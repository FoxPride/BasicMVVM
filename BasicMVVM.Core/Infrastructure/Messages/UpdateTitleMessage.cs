using $ext_safeprojectname$.Core.ViewModels;

namespace $ext_safeprojectname$.Core.Infrastructure.Messages
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Helper class for <see cref="ChangeTitleViewModel" /> class to change title of main window.
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class UpdateTitleMessage
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Initializes a new instance of the <see cref="UpdateTitleMessage"/> class. </summary>
        ///
        /// <param name="title">    The title. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public UpdateTitleMessage(string title)
        {
            Title = title;
        }
        
        public string Title { get; }
    }
}