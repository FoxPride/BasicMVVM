using System.Windows.Input;
using BasicMVVM.Core.Infrastructure.Commands;
using BasicMVVM.Core.Infrastructure.Messages;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace BasicMVVM.Core.ViewModels
{
    /// <summary>
    ///     The second window view model.
    /// </summary>
    public class SecondWindowViewModel : ObservableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SecondWindowViewModel" /> class.
        /// </summary>
        public SecondWindowViewModel()
        {
            CloseWindowCommand = BasicCommands.CloseWindowCommand;
            ChangeTitleCommand = new RelayCommand<string>(UpdateTitle);
        }

        /// <summary>
        ///     Gets command to close window.
        /// </summary>
        public ICommand CloseWindowCommand { get; }

        /// <summary>
        ///     Gets command to change title.
        /// </summary>
        public ICommand ChangeTitleCommand { get; }

        /// <summary>
        ///     Sends message to update main window title.
        /// </summary>
        /// <param name="title">
        ///     The title.
        /// </param>
        private void UpdateTitle(string title)
        {
            WeakReferenceMessenger.Default.Send(new UpdateTitleMessage(title));
        }
    }
}