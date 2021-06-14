// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

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

    /// <summary>
    /// The main window view model.
    /// </summary>
    public class MainWindowViewModel : ObservableObject
    {
        /// <summary>
        ///     Gets the <see cref="ILogger" /> instance to use.
        /// </summary>
        private readonly ILogger loggerService = Ioc.Default.GetRequiredService<ILogger>();

        /// <summary>
        /// The title of window.
        /// </summary>
        private string title = "Main window";

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            this.ChangeTitleCommand = new RelayCommand<string>(this.UpdateTitle);
            this.CloseWindowCommand = new RelayCommand(this.CloseWindow);
            this.ShowWindowCommand = new RelayCommand<ViewsEnum>(this.ShowWindow);

            this.loggerService.Log("Logged");

            WeakReferenceMessenger.Default.Register<UpdateTitleMessage>(this, this.UpdateTitleMessageReceived);
        }

        /// <summary>
        /// Gets the change title command.
        /// </summary>
        public ICommand ChangeTitleCommand { get; }

        /// <summary>
        /// Gets the close window command.
        /// </summary>
        public ICommand CloseWindowCommand { get; }

        /// <summary>
        /// Gets the show window command.
        /// </summary>
        public ICommand ShowWindowCommand { get; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title
        {
            get => this.title;
            set => this.SetProperty(ref this.title, value);
        }

        /// <summary>
        /// Closes app.
        /// </summary>
        private void CloseWindow()
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Sends message to show window.
        /// </summary>
        /// <param name="view">
        /// The view from views enumeration.
        /// </param>
        private void ShowWindow(ViewsEnum view)
        {
            WeakReferenceMessenger.Default.Send(new ShowWindowMessage(view));
        }

        /// <summary>
        /// Updates title.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        private void UpdateTitle(string title)
        {
            this.Title = title;
        }

        /// <summary>
        /// Handles received message.
        /// </summary>
        /// <param name="recipient">
        /// The recipient.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        private void UpdateTitleMessageReceived(object recipient, UpdateTitleMessage message)
        {
            this.UpdateTitle(message.Title);
        }
    }
}