using core.Notifications;
using MediatR;
using Microsoft.AspNetCore.SignalR;
using webapp.Hubs;

namespace webapp;

public class ChatNotificationHandler(IHubContext<ChatHub> hub) : INotificationHandler<ChatCreated>
{
  public async Task Handle(ChatCreated notification, CancellationToken cancellationToken)
  {
    await hub.Clients.All.SendCoreAsync("MessageFromServer", new[] { notification.Model });
  }
}