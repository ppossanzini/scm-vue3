using core.Commands;
using core.dto;
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
  
  
}