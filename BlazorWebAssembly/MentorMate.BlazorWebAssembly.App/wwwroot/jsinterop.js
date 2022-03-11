window.Chat = {
    scrollToBottom: function () {
        var messagesContent = document.querySelector('.messages-content');
        setTimeout(() => {
            messagesContent.scrollTop = messagesContent.scrollHeight;
        }, 0);
        
    }
}