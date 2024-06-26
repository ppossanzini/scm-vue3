using AutoMapper;
using AutoMapper.QueryableExtensions;
using core.dto;
using core.Query;
using handlers.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace handlers.Query;

public class ChatQuery(DB db, IMapper mapper) :
  IRequestHandler<GetChat, ChatInfo?>,
  IRequestHandler<ListChats, IEnumerable<ChatInfo>>
{
  public async Task<ChatInfo?> Handle(GetChat request, CancellationToken cancellationToken)
  {
    var result =
      (from c in db.Chats
        where c.Id == request.Id
        select c).ProjectTo<ChatInfo>(mapper.ConfigurationProvider); 

    return await result.FirstOrDefaultAsync(cancellationToken);

  }

  public async Task<IEnumerable<ChatInfo>> Handle(ListChats request, CancellationToken cancellationToken)
  {
    // var result = from c in db.Chats
    //   select new ChatInfo()
    //   {
    //     Name = c.Name,
    //     CreationDate = c.CreationDate,
    //     Id = c.Id
    //   };

    var result = db.Chats.ProjectTo<ChatInfo>(mapper.ConfigurationProvider);
    
    return await result.ToListAsync(cancellationToken);
  }
  
  
  
  
  
  
}