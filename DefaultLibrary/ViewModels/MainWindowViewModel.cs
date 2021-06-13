namespace DefaultLibrary.ViewModels
{
    using System.Windows;
    using System.Windows.Input;

    using DefaultLibrary.Infrastructure.Enums;
    using DefaultLibrary.Infrastructure.Messages;
    using DefaultLibrary.Services.Interfaces;

    using Microsoft.Toolkit.Mvvm.ComponentModel;
    using Microsoft.Toolkit.Mvvm.DependencyInjection;
    using Microsoft.Toolkit.Mvvm.Input;
    using Microsoft.Toolkit.Mvvm.Messaging;

    public class MainWindowViewModel : ObservableObject
    {
        /// <summary>
        ///     Gets the <see cref="ILogger" /> instance to use.
        /// </summary>
        private readonly ILogger loggerService = Ioc.Default.GetRequiredService<ILogger>();

        private string title = "Main window";

        public MainWindowViewModel()
        {
            this.ChangeTitleCommand = new RelayCommand<string>(this.UpdateTitle);
            this.CloseWindowCommand = new RelayCommand(this.CloseWindow);
            this.ShowWindowCommand = new RelayCommand<ViewsEnum>(this.ShowWindow);

            this.loggerService.Log("Logged");

            WeakReferenceMessenger.Default.Register<UpdateTitleMessage>(this, this.UpdateTitleMessageReceived);
        }

        public ICommand ChangeTitleCommand { get; }

        public ICommand CloseWindowCommand { get; }

        public ICommand ShowWindowCommand { get; }

        /// <summary>Window title</summary>
        public string Title
        {
            get => this.title;
            set => this.SetProperty(ref this.title, value);
        }

        private void CloseWindow()
        {
            Application.Current.Shutdown();
        }

        private void ShowWindow(ViewsEnum view)
        {
            WeakReferenceMessenger.Default.Send(new ShowWindowMessage(view));
        }

        private void UpdateTitle(string title)
        {
            this.Title = title;
        }

        private void UpdateTitleMessageReceived(object recipient, UpdateTitleMessage message)
        {
            this.UpdateTitle(message.Title);
        }
    }
}