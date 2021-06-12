using System.Windows;
using System.Windows.Input;
using DefaultLibrary.Helpers;
using DefaultLibrary.Services.Interfaces;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;

namespace DefaultLibrary.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        /// <summary>
        /// Gets the <see cref="ILogger"/> instance to use.
        /// </summary>
        private readonly ILogger _loggerService = Ioc.Default.GetRequiredService<ILogger>();

        public MainWindowViewModel()
        {
            ChangeTitleCommand = new RelayCommand<string>(UpdateTitle);
            CloseWindowCommand = new RelayCommand(CloseWindow);

            _loggerService.Log("Logged");
        }

        #region Title : string - Window title

        private string _title = "Main window";

        /// <summary>Window title</summary>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        #endregion

        #region Commands
        public ICommand ChangeTitleCommand { get; }

        public ICommand CloseWindowCommand { get; }

        #endregion

        #region Methods

        private void UpdateTitle(string title)
        {
            Title = title;
        }

        private void CloseWindow()
        {
            Application.Current.Shutdown();
        }

        #endregion
    }
}
