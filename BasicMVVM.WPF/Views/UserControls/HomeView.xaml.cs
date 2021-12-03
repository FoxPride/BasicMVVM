﻿using $ext_safeprojectname$.WPF.Views.Windows;
using System.Windows;

namespace $ext_safeprojectname$.WPF.Views.UserControls
{
    /// <summary>   A home view. </summary>
    public partial class HomeView
    {
        /// <summary>   Default constructor. </summary>
        public HomeView()
        {
            InitializeComponent();
        }

        private void OpenSecondWindow(object sender, RoutedEventArgs e)
        {
            new SecondWindow().Show();
        }
    }
}