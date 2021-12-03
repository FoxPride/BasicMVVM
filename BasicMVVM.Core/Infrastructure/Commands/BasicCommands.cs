using $ext_safeprojectname$.Core.Stores;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace $ext_safeprojectname$.Core.Infrastructure.Commands
{
    /// <summary>   Basic commands for app needs. </summary>
    public static class BasicCommands
    {
        /// <summary>   Static constructor. </summary>
        static BasicCommands()
        {
            NavigateCommand = new RelayCommand<ObservableObject>(Navigate);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Navigates between views with <see cref="NavigationStore"/>. </summary>
        ///
        /// <value> The 'navigate' command. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static ICommand NavigateCommand { get; }

        private static void Navigate(ObservableObject viewModel)
        {
            NavigationStore.CurrentViewModel = viewModel;
        }
    }
}