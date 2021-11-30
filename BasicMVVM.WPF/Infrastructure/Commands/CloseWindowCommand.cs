using Microsoft.Toolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace BasicMVVM.WPF.Infrastructure.Commands
{
    public static class CloseWindowCommand
    {
        static CloseWindowCommand()
        {
            Close = new RelayCommand<Window>(CloseWindow);
        }

        public static ICommand Close { get; }

        private static void CloseWindow(Window wnd)
        {
            wnd?.Close();
        }
    }
}