using $ext_safeprojectname$.Core.Infrastructure.Messages;
using $ext_safeprojectname$.Core.Services.Interfaces;
using $ext_safeprojectname$.Core.Stores;
using Microsoft.Extensions.Logging;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace $ext_safeprojectname$.Core.ViewModels
{
    /// <summary>   A ViewModel for the main window. </summary>
    public class MainWindowViewModel : ObservableRecipient, IRecipient<UpdateTitleMessage>
    {
        private readonly ILogger<MainWindowViewModel> _loggerService;
        private readonly IUpdater _updaterService;

        private string _title = "Main window";

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="loggerService">    The logger service. </param>
        /// <param name="updaterService">   The updater service. </param>
        /// <param name="navigationStore">  The navigation store. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MainWindowViewModel(ILogger<MainWindowViewModel> loggerService, IUpdater updaterService, NavigationStore navigationStore)
        {
            _loggerService = loggerService;
            _updaterService = updaterService;

            NavigationStore = navigationStore;

            IsActive = true; //Activates ViewModel to get messages

            _loggerService.LogInformation("Logged");
            _updaterService.CheckForUpdate();
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public NavigationStore NavigationStore { get; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Handles received message <see cref="UpdateTitleMessage"/>. </summary>
        ///
        /// <param name="message">  The message being received. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Receive(UpdateTitleMessage message)
        {
            UpdateTitle(message.Title);
        }

        private void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}