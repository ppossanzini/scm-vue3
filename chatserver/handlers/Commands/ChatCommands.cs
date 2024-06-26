using core.Commands;
using core.dto;
using handlers.Model;
using MediatR;

namespace handlers.Commands;

public class ChatCommands(DB db): IRequestHandler<CreateChat,ChatInfo>
{
  
  public async Task<ChatInfo> Handle(CreateChat request, CancellationToken cancellationToken)
  {
    var c = new Chat() { Name = request.Name, CreationDate = DateTime.Now}; 
    db.Chats.Add(c);

    await db.SaveChangesAsync(cancellationToken);

    return new ChatInfo()
    {
      Id = c.Id, CreationDate = c.CreationDate, Name = c.Name
    };
  }
}