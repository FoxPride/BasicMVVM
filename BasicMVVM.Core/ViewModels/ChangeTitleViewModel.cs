using $ext_safeprojectname$.Core.Infrastructure.Messages;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System.Windows.Input;

namespace $ext_safeprojectname$.Core.ViewModels
{
    /// <summary>   A ViewModel for the change title via <see cref="WeakReferenceMessenger"/>. </summary>
    public class ChangeTitleViewModel : ObservableObject
    {
        public ChangeTitleViewModel()
        {
            ChangeTitleCommand = new RelayCommand<string>(UpdateTitle);
        }

        public ICommand ChangeTitleCommand { get; }

        private void UpdateTitle(string title)
        {
            WeakReferenceMessenger.Default.Send(new UpdateTitleMessage(title));
        }
    }
}