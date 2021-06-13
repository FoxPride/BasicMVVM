namespace DefaultLibrary.ViewModels
{
    using Microsoft.Toolkit.Mvvm.DependencyInjection;

    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => Ioc.Default.GetService<MainWindowViewModel>();

        public SecondWindowViewModel SecondWindowModel => Ioc.Default.GetService<SecondWindowViewModel>();
    }
}