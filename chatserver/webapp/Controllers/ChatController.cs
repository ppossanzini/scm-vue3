using core.Commands;
using core.dto;
using core.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace webapp.Controllers;

[Route("chat")]
public class ChatController(IMediator mediator) : ControllerBase
{
  [HttpPost("{name}")]
  [ProducesResponseType(typeof(ChatInfo), 200)]
  public async Task<IActionResult> CreateChat(string name)
  {
    var c = await mediator.Send(new CreateChat() { Name = name });
    return Ok(c);
  }

  [HttpGet]
  public async Task<IEnumerable<ChatInfo>> ListChats()
  {
    return await mediator.Send(new ListChats());
  }


  [HttpGet("{id}")]
  public async Task<IActionResult> GetChat(int id)
  {
    var c = await mediator.Send(new GetChat() { Id = id });
    if (c != null) return Ok(c);
    return NotFound();
  }
}