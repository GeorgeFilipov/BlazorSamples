namespace MentorMate.Shared.Models
{
    public class Message
    {
        public string UserName { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public string Text { get; set; } = string.Empty;

        public bool SendByMe { get; set; } = true;
    }
}