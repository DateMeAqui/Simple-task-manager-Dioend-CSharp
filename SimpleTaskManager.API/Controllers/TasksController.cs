using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleTaskManager.Application.UseCase.Task;
using SimpleTaskManager.Communication.Requests;
using SimpleTaskManager.Communication.Response;

namespace SimpleTaskManager.API.Controllers
{
    public class TasksController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult createTask([FromBody] RequestTaskJson request)
        {

            var response = new RegisterTaskUseCase().Execute(request);

            return Created(string.Empty, response);
           
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseTaskJson>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new GetAllTaskUseCase().Execute();

            if(response == null)
            {
                return NoContent();
            }
            return Ok(response);
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseFullTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Get(Guid id) {

            var response = new GetByIdTaskUseCase().Execute(id);

            if (response == null)
                return NotFound(new ResponseErrorJson("Tarefa não encontrada !"));
            return Ok(response);
        }

        [HttpPatch]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult PatchTask(Guid id, [FromBody] RequestUpdateTask request)
        {
            new UpdateTaskUseCase().Execute(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteTask(Guid id)
        {
            new DeleteTaskUseCase().Execute(id);

            return NoContent();
        }
    }
}
