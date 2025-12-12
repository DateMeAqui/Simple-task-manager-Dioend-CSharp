using Microsoft.AspNetCore.Mvc;
using SimpleTaskManager.Application.UseCase.Task;
using SimpleTaskManager.Communication.Requests;
using SimpleTaskManager.Communication.Response;

namespace SimpleTaskManager.API.Controllers
{
    public class TasksController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult createTask([FromBody] RequestTaskJson request)
        {
            var response = new RegisterTaskUseCase().Execute(request);
           
            return Ok(response);
        }
    }
}
