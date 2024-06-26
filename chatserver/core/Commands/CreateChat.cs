using core.dto;
using MediatR;

namespace core.Commands;

public class CreateChat:IRequest<ChatInfo?>
{
  public string Name { get; set; }
}