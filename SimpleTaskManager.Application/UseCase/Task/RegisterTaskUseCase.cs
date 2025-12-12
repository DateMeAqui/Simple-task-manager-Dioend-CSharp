using SimpleTaskManager.Application.Database;
using SimpleTaskManager.Communication.Requests;
using SimpleTaskManager.Communication.Response;

namespace SimpleTaskManager.Application.UseCase.Task
{
    public class RegisterTaskUseCase : DatabaseTableTask
    {
        public ResponseTaskJson Execute(RequestTaskJson request) 
        {
            var newTask = new RequestTaskJson
            {
                Name = request.Name,
                Description = request.Description,
                priority = request.priority,
                dueDate = request.dueDate,
            };

            Tasks.Add(newTask);

            var response = new ResponseTaskJson
            {
                Id = request.Id,
                Name = request.Name,
            };
            return response;
        }
    }
}
