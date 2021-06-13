namespace DefaultLibrary.ViewModels
{
    using System.Windows.Input;

    using DefaultLibrary.Infrastructure.Messages;

    using Microsoft.Toolkit.Mvvm.ComponentModel;
    using Microsoft.Toolkit.Mvvm.Input;
    using Microsoft.Toolkit.Mvvm.Messaging;

    public class SecondWindowViewModel : ObservableObject
    {
        public SecondWindowViewModel()
        {
            this.ChangeTitleCommand = new RelayCommand<string>(this.UpdateTitle);
        }

        public ICommand ChangeTitleCommand { get; }

        private void UpdateTitle(string title)
        {
            WeakReferenceMessenger.Default.Send(new UpdateTitleMessage(title));
        }
    }
}