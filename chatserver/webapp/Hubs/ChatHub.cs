using core.Commands;
using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace webapp.Hubs;

public class ChatHub(ILogger<ChatHub> logger, IMediator mediator) : Hub
{
  public override Task OnConnectedAsync()
  {
    logger.LogDebug($"New Device connected {this.Context.ConnectionId}");

    return base.OnConnectedAsync();
  }

  public override Task OnDisconnectedAsync(Exception? exception)
  {
    return base.OnDisconnectedAsync(exception);
  }

  public async Task MessageFromClient(string message)
  {
    await mediator.Send(new CreateChat() { Name = message });
    logger.LogInformation($"Message from {Context.ConnectionId} : {message}");
  }
}