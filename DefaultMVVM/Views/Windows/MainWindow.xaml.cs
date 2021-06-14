// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="Monosnap Inc.">
//   Andrew Baiderin © 2021
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DefaultMVVM.Views.Windows
{
    using DefaultLibrary.Infrastructure.Enums;
    using DefaultLibrary.Infrastructure.Messages;

    using Microsoft.Toolkit.Mvvm.Messaging;

    /// <summary>
    /// The main window.
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            WeakReferenceMessenger.Default.Register<ShowWindowMessage>(this, ShowWindowMessageReceived);
        }

        /// <summary>
        /// Handles received message.
        /// </summary>
        /// <param name="recipient">
        /// The recipient.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        private static void ShowWindowMessageReceived(object recipient, ShowWindowMessage message)
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
            }
        }
    }
}