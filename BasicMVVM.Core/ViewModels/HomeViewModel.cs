using BasicMVVM.Core.Infrastructure.Commands;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace BasicMVVM.Core.ViewModels
{
    public class HomeViewModel : ObservableObject
    {
        public HomeViewModel()
        {
            CloseApplicationCommand = BasicCommands.CloseApplicationCommand;
        }

        public ICommand CloseApplicationCommand { get; }
    }
}