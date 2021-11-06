using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;

namespace BasicMVVM.Core.Infrastructure.Commands
{
    public static class BasicCommands
    {
        public static ICommand CloseWindowCommand
        {
            get
            {
                return new RelayCommand<Window>
                    (p => p?.Close());
            }
        }   

        public static ICommand CloseApplicationCommand
        {
            get
            {
                return new RelayCommand
                    (() => Application.Current.Shutdown());
            }
        }
    }
}