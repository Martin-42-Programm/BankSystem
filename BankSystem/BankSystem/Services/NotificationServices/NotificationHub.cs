using Microsoft.AspNetCore.SignalR;
namespace BankSystem.Services.NotificationServices;

public class NotificationHub : Hub
{
    public async Task SendNotification(string userId, string message)
    {
        await Clients.User(userId).SendAsync("ReceiveNotification", message);
    }
}