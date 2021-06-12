using System.Windows;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace DefaultLibrary.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            ChangeTitleCommand = new RelayCommand<string>(UpdateTitle);
            CloseWindowCommand = new RelayCommand(CloseWindow);
        }

        #region Title : string - Window title

        private string _title = "Test title";

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
