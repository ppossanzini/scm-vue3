using core.dto;
using MediatR;

namespace core.Query;

public class ListChats: 
  IRequest<IEnumerable<ChatInfo>>
{
  
}