// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SecondWindowViewModel.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultLibrary.ViewModels
{
    using System.Windows.Input;

    using DefaultLibrary.Infrastructure.Messages;

    using Microsoft.Toolkit.Mvvm.ComponentModel;
    using Microsoft.Toolkit.Mvvm.Input;
    using Microsoft.Toolkit.Mvvm.Messaging;

    /// <summary>
    /// The second window view model.
    /// </summary>
    public class SecondWindowViewModel : ObservableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondWindowViewModel"/> class.
        /// </summary>
        public SecondWindowViewModel()
        {
            this.ChangeTitleCommand = new RelayCommand<string>(this.UpdateTitle);
        }

        /// <summary>
        /// Gets command to change title.
        /// </summary>
        public ICommand ChangeTitleCommand { get; }

        /// <summary>
        /// Sends message to update main window title.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        private void UpdateTitle(string title)
        {
            WeakReferenceMessenger.Default.Send(new UpdateTitleMessage(title));
        }
    }
}