namespace DefaultLibrary.Infrastructure.Messages
{
    public class UpdateTitleMessage
    {
        public UpdateTitleMessage(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }
    }
}