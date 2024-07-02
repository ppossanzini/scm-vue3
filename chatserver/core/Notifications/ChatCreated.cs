using core.dto;
using MediatR;

namespace core.Notifications;

public class ChatCreated : INotification
{
  public ChatInfo Model { get; set; }
}