﻿using BasicMVVM.Core.Stores;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace BasicMVVM.Core.Infrastructure.Commands
{
    /// <summary>
    ///     Basic commands for app needs.
    /// </summary>
    public static class BasicCommands
    {
        static BasicCommands()
        {
            NavigateCommand = new RelayCommand<ObservableObject>(Navigate);
        }

        /// <summary>
        ///     Navigates between views with <see cref="NavigationStore"/>.
        /// </summary>
        public static ICommand NavigateCommand { get; }

        private static void Navigate(ObservableObject viewModel)
        {
            NavigationStore.CurrentViewModel = viewModel;
        }
    }
}