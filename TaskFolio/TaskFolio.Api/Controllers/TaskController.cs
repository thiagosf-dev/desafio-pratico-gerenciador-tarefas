using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication.Responses;
using TaskFolio.Application.UseCases.Task.Delete;
using TaskFolio.Application.UseCases.Task.GetAll;
using TaskFolio.Application.UseCases.Task.GetById;
using TaskFolio.Application.UseCases.Task.Register;
using TaskFolio.Application.UseCases.Task.Update;
using TaskFolio.Communication.Requests;
using TaskFolio.Communication.Responses;

namespace TaskFolio.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        new UpdateTaskUseCase().Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new GetAllTaskUseCase().Execute();

        if (response.Tasks.Count != 0)
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetByIdl([FromRoute] int id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        new DeleteTaskByIdUseCase().Execute(id);
        return NoContent();
    }
}
