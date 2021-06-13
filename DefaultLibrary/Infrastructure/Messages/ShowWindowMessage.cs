namespace DefaultLibrary.Infrastructure.Messages
{
    using DefaultLibrary.Infrastructure.Enums;

    public class ShowWindowMessage
    {
        public ShowWindowMessage(ViewsEnum view)
        {
            this.View = view;
        }

        public ViewsEnum View { get; set; }
    }
}