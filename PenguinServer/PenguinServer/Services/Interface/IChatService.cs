namespace PenguinServer.Services.Interface
{
    public interface IChatService
    {
        public string[] GetChats();
        public void SendChatMessage(string message);
    }
}
