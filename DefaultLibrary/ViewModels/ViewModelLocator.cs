using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace DefaultLibrary.ViewModels
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => Ioc.Default.GetService<MainWindowViewModel>();
    }
}
