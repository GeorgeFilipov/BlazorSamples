namespace MentorMate.Shared.Models
{
    public class ChatState
    {
        public event Action? OnChange;

        public bool ShowChatWindow { get; set; }

        public void ToggleChatWindow()
        {
            ShowChatWindow = !ShowChatWindow;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
