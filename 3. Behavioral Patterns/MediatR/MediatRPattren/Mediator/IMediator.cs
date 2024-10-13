using MediatRPattren.Component;

namespace MediatRPattren.Mediator
{
    public interface IMediator
    {
        public void SendMessage(string message, int chatId);

        public void RegisterChatUser(IUser user);
    }

    public class ChatMediator : IMediator
    {
        private readonly Dictionary<int, IUser> _users;

        public ChatMediator()
        {
            _users = new Dictionary<int, IUser>();
        }

        public void RegisterChatUser(IUser user)
        {
            if (!_users.ContainsKey(user.ChatId))
            {
                _users.Add(user.ChatId, user);
            }
        }

        public void SendMessage(string message, int chatId)
        {
            foreach (var user in _users.Where(x => x.Key != chatId))
            {
                user.Value.RecieveMessage(message);
            }
        }
    }
}
