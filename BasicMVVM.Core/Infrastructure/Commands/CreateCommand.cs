using System.Windows.Input;

namespace BasicMVVM.Core.Infrastructure.Commands
{
    public delegate ICommand CreateCommand<in TViewModel>(TViewModel viewModel);
}