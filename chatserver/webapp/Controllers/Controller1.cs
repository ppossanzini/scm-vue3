using core.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using webapp.dto;

namespace webapp.Controllers;

[Route("miocontroller")]
public class Controller1(IMediator mediator) : ControllerBase
{

  // [HttpPost("/chat/{name}")]
  // public async Task<IActionResult> CreateChat(string name)
  // {
  //   await mediator.Send(new CreateChat() { Name = name });
  //   return Ok();
  // }
  

  // GET
  [HttpGet, HttpPost]
  [Route("{username}")]
  [ProducesResponseType(typeof(ProjectInfo), 200)]
  public IActionResult Index(string username, string? projectname = null, [FromBody] object? payload = null)
  {
    return Ok(new ProjectInfo() { username = username, projectName = projectname });
  }

  [HttpGet("u/{username}")]
  [HttpPost("u/{username}/update")]
  public async Task<IActionResult> getUserName(CancellationToken cancellationToken)
  {
    return Ok();
  }

  [HttpGet, Route("~/project")]
  public ProjectInfo GetProjectInfo()
  {
    return new ProjectInfo() { };
  }

  //GET serverzz/miocontroller
  //GET serverzz/miocontroller/ppossanzini?projectname=progetto1&
}