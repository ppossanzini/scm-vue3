using core.Commands;
using core.dto;
using core.Notifications;
using core.Query;
using handlers.Model;
using MediatR;

namespace handlers.Commands;

public class ChatCommands(DB db, IMediator mediator): IRequestHandler<CreateChat,ChatInfo?>
{
  
  public async Task<ChatInfo?> Handle(CreateChat request, CancellationToken cancellationToken)
  {
    var c = new Chat() { Name = request.Name, CreationDate = DateTime.Now}; 
    db.Chats.Add(c);

    await db.SaveChangesAsync(cancellationToken);

    
    var result =  await mediator.Send(new GetChat() { Id = c.Id },cancellationToken);
    await mediator.Publish(new ChatCreated() { Model = result });
    return result;
    // return new ChatInfo()
    // {
    //   Id = c.Id, CreationDate = c.CreationDate, Name = c.Name
    // };
  }
}