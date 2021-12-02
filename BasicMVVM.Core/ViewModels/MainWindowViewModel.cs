﻿using BasicMVVM.Core.Infrastructure.Messages;
using BasicMVVM.Core.Services.Interfaces;
using BasicMVVM.Core.Stores;
using Microsoft.Extensions.Logging;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace BasicMVVM.Core.ViewModels
{
    /// <summary>   A ViewModel for the main window. </summary>
    public class MainWindowViewModel : ObservableRecipient, IRecipient<UpdateTitleMessage>, IRecipient<UpdateViewModelMessage>
    {
        private readonly ILogger<MainWindowViewModel> _loggerService;
        private readonly IUpdater _updaterService;

        private string _title = "Main window";

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <param name="loggerService">    The logger service. </param>
        /// <param name="updaterService">   The updater service. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public MainWindowViewModel(ILogger<MainWindowViewModel> loggerService, IUpdater updaterService)
        {
            _loggerService = loggerService;
            _updaterService = updaterService;

            IsActive = true; //Activates ViewModel to get messages

            _loggerService.LogInformation("Logged");
            _updaterService.CheckForUpdate();
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ObservableObject CurrentViewModel => NavigationStore.CurrentViewModel;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Handles received message <see cref="UpdateTitleMessage"/>. </summary>
        ///
        /// <param name="message">  The message being received. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Receive(UpdateTitleMessage message)
        {
            UpdateTitle(message.Title);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Handles received message <see cref="UpdateViewModelMessage"/>. </summary>
        ///
        /// <param name="message">  The message being received. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Receive(UpdateViewModelMessage message)
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}