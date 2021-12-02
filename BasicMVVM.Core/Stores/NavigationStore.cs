using BasicMVVM.Core.Helpers;
using BasicMVVM.Core.Infrastructure.Messages;
using BasicMVVM.Core.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;

namespace BasicMVVM.Core.Stores
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Store for saving current view model of main window. Changing current view model allows to
    /// change views with data template.
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public static class NavigationStore
    {
        private static ObservableObject _currentViewModel;

        static NavigationStore()
        {
            CurrentViewModel = HostHelper.Host.Services.GetRequiredService<HomeViewModel>();
        }

        public static ObservableObject CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                WeakReferenceMessenger.Default.Send(new UpdateViewModelMessage());
            }
        }
    }
}