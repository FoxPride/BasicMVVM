using BasicMVVM.Core.Infrastructure.Enums;
using BasicMVVM.Core.Infrastructure.Messages;

namespace BasicMVVM.WPF.Views.Windows
{
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
            InitializeComponent();
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