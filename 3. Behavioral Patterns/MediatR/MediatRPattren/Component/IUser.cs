using MediatRPattren.Mediator;

namespace MediatRPattren.Component
{
    public interface IUser
    {
        int ChatId { get; }

        void SendMessage(string message);

        void RecieveMessage(string message);
    }

    public class User : IUser
    {
        private readonly IMediator _mediator;

        private string _username;

        private int _chatId;

        public User(IMediator mediator, string username, int chatId)
        {
            _mediator = mediator;
            _username = username;
            _chatId = chatId;
        }

        public int ChatId => _chatId;

        public void RecieveMessage(string message)
        {
            Console.WriteLine($"{_username} received message: {message}");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{_username} sending message: {message}");
            _mediator.SendMessage(message, _chatId);
        }
    }
}
