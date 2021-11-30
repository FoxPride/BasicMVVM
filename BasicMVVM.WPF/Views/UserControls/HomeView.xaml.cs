using BasicMVVM.WPF.Views.Windows;
using System.Windows;

namespace BasicMVVM.WPF.Views.UserControls
{
    public partial class HomeView
    {
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