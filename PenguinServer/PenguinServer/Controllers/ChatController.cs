using Microsoft.AspNetCore.Mvc;
using PenguinServer.Services.Interface;

namespace PenguinServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;
        public ChatController(IChatService chatService) 
        { 
            _chatService = chatService;
        }

        [HttpGet("messages")]
        public List<string> GetChatMessages()
        {
            return _chatService.GetChats().ToList();
        }

        [HttpPost("chat")]
        public void Chat(string message)
        {
            _chatService.SendChatMessage(message);
        }
    }
}
