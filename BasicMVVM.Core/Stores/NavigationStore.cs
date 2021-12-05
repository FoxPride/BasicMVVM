using $ext_safeprojectname$.Core.Helpers;
using $ext_safeprojectname$.Core.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace $ext_safeprojectname$.Core.Stores
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Store for saving current view model of main window. Changing current view model allows to
    /// change views with data template.
    /// </summary>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class NavigationStore : ObservableObject
    {
        private ObservableObject _currentViewModel;

        public NavigationStore()
        {
            CurrentViewModel = HostHelper.Host.Services.GetRequiredService<HomeViewModel>();
        }

        public ObservableObject CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }
    }
}