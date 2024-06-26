using core.Commands;
using core.dto;
using MediatR;

namespace handlers.Commands;

public class ChatCommands: IRequestHandler<CreateChat,ChatInfo>
{
  
  public Task<ChatInfo> Handle(CreateChat request, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}