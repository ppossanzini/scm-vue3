using core.dto;
using MediatR;

namespace core.Query;

public class GetChat : IRequest<ChatInfo>
{
  public int Id { get; set; }
}