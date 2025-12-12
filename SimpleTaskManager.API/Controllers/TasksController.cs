using Microsoft.AspNetCore.Mvc;

namespace SimpleTaskManager.API.Controllers
{
    public class TasksController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(), StatusCodes.Status201Created]
        public IActionResult createTask([FromBody] request)
        {
            return Created();
        }
    }
}
