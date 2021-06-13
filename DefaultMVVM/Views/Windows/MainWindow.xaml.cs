namespace DefaultMVVM.Views.Windows
{
    using System;

    using DefaultLibrary.Infrastructure.Enums;
    using DefaultLibrary.Infrastructure.Messages;

    using Microsoft.Toolkit.Mvvm.Messaging;

    public partial class MainWindow
    {
        public MainWindow()
        {
            this.InitializeComponent();
            WeakReferenceMessenger.Default.Register<ShowWindowMessage>(this, this.ShowWindowMessageReceived);
        }

        private void ShowWindowMessageReceived(object recipient, ShowWindowMessage message)
        {
            switch (message.View)
            {
                case ViewsEnum.MainWindow:
                    new MainWindow().Show();
                    break;

                case ViewsEnum.SecondWindow:
                    new SecondWindow().Show();
                    break;

                case ViewsEnum.ThirdWindow:
                    new ThirdWindow().Show();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}