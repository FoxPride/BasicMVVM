using System.Windows.Input;
using BasicMVVM.Core.Infrastructure.Commands;
using BasicMVVM.Core.Infrastructure.Enums;
using BasicMVVM.Core.Infrastructure.Messages;
using BasicMVVM.Core.Services.Interfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using SquirrelHelper;

namespace BasicMVVM.Core.ViewModels
{
    /// <summary>
    ///     The main window view model.
    /// </summary>
    public class MainWindowViewModel : ObservableRecipient, IRecipient<UpdateTitleMessage>
    {
        /// <summary>
        ///     Gets the <see cref="ILogger" /> instance to use.
        /// </summary>
        private readonly ILogger _loggerService = Ioc.Default.GetRequiredService<ILogger>();

        /// <summary>
        ///     Gets the <see cref="IUpdater" /> instance to use.
        /// </summary>
        private readonly IUpdater _updaterService = Ioc.Default.GetRequiredService<IUpdater>();

        /// <summary>
        ///     The title of window.
        /// </summary>
        private string _title = "Main window";

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainWindowViewModel" /> class.
        /// </summary>
        public MainWindowViewModel()
        {
            IsActive = true; //Activates ViewModel to get messages

            CloseApplicationCommand = BasicCommands.CloseApplicationCommand;

            ChangeTitleCommand = new RelayCommand<string>(UpdateTitle);
            ShowWindowCommand = new RelayCommand<ViewsEnum>(ShowWindow);

            _loggerService.Log("Logged");
            _updaterService.CheckUpdates();
        }

        /// <summary>
        ///     Gets the close window command.
        /// </summary>
        public ICommand CloseApplicationCommand { get; }

        /// <summary>
        ///     Gets the change title command.
        /// </summary>
        public ICommand ChangeTitleCommand { get; }

        /// <summary>
        ///     Gets the show window command.
        /// </summary>
        public ICommand ShowWindowCommand { get; }

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        
        public void Receive(UpdateTitleMessage message)
        {
            UpdateTitle(message.Title);
        }

        /// <summary>
        ///     Sends message to show window.
        /// </summary>
        /// <param name="view">
        ///     The view from views enumeration.
        /// </param>
        private void ShowWindow(ViewsEnum view)
        {
            WeakReferenceMessenger.Default.Send(new ShowWindowMessage(view));
        }

        /// <summary>
        ///     Updates title.
        /// </summary>
        /// <param name="title">
        ///     The title.
        /// </param>
        private void UpdateTitle(string title)
        { 
            Title = title;
        }
    }
}