using BasicMVVM.Core.Infrastructure.Messages;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System.Windows.Input;

namespace BasicMVVM.Core.ViewModels
{
    public class ChangeTitleViewModel : ObservableObject
    {
        public ChangeTitleViewModel()
        {
            ChangeTitleCommand = new RelayCommand<string>(UpdateTitle);
        }

        public ICommand ChangeTitleCommand { get; }

        /// <summary>
        ///     Sends message to update main window title.
        /// </summary>
        private void UpdateTitle(string title)
        {
            WeakReferenceMessenger.Default.Send(new UpdateTitleMessage(title));
        }
    }
}