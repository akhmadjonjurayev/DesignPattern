using MediatRPattren.Component;
using MediatRPattren.Mediator;

Console.WriteLine("Mediator Pattern Demo Chat Application");

var chatApp = new ChatMediator();

var johnDoe = new User(chatApp, "John Doe", 1);
var jackSmith = new User(chatApp, "Jack Smith", 2);
var bobMartin = new User(chatApp, "Bob Martin", 3);

chatApp.RegisterChatUser(johnDoe);
chatApp.RegisterChatUser(jackSmith);
chatApp.RegisterChatUser(bobMartin);

johnDoe.SendMessage("Hello, everyone!");
jackSmith.SendMessage("Any one got extra phone charger?");
bobMartin.SendMessage("Got one Extra Phone Charger");

Console.ReadKey();
