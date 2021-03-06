using Microsoft.Toolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace $ext_safeprojectname$.WPF.Infrastructure.Commands
{
    /// <summary>   A command to close window. </summary>
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