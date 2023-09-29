using PenguinServer.Controllers;
using PenguinServer.Services.Interface;

namespace PenguinServer.Services
{
    public class ChatService : IChatService
    {

        public List<string> Messages { get; set; }
        public ChatService()
        {
            Messages = new List<string>() { "Bad Apple" };
        }

        public string[] GetChats()
        {
            return Messages.ToArray();
        }

        public void SendChatMessage(string message)
        {
            Messages.Add(message);
        }
    }
}
