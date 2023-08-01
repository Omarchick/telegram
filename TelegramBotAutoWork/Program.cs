using TelegramTest;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

AutoSender.StartSending();

app.Run();
